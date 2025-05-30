using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool CompileLUA()
        {
            bool res = false;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            StreamReader outputReader = null;
            StreamReader errorReader = null;
            ConsoleTextBox.AppendText("Компиляция скрипта\n");
            if (lua5_4.Checked)
                startInfo.FileName = Settings.sGetUtilPath() + "\\luac.exe";
            else
                startInfo.FileName = Settings.sGetUtilPath() + "\\luac53.exe";
            startInfo.Arguments = "  -o out.luac runscript.lua";
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            Process process = Process.Start(startInfo);
            outputReader = process.StandardOutput;
            errorReader = process.StandardError;
            process.WaitForExit();
            String error = errorReader.ReadToEnd();
            if (error.Length == 0)
            {
                ConsoleTextBox.AppendText(error + Environment.NewLine);
                ConsoleTextBox.AppendText(outputReader.ReadToEnd() + Environment.NewLine);
                ConsoleTextBox.AppendText("Компиляция скрипта выполнена успешно\n");
                res = true;
            }
            else
            {
                ConsoleTextBox.AppendText(outputReader.ReadToEnd() + Environment.NewLine);
                ConsoleTextBox.AppendText(error + Environment.NewLine);
                ConsoleTextBox.AppendText("Ошибки в процессе компиляции, выполнение приостановлено\n");
            }
            return res;

        }
        private bool vLuaLink()
        {
            bool res = false;
            byte[] buffer = new byte[1024];
            int readLen;
            FileStream fsa = File.Create("runscript.lua");
            FileStream LibFile = null;
            fsa.Close();
            fsa = File.OpenWrite("runscript.lua");
            for (int i = 0; i < LibChecked.Items.Count; i++)
            {
                if (LibChecked.GetItemChecked(i) == true)
                {
                    LibFile = File.OpenRead(Settings.sGetLIBPath() + "\\" + LibChecked.Items[i].ToString());
                    while ((readLen = LibFile.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fsa.Write(buffer, 0, readLen);
                    }
                    fsa.WriteByte((byte)('\n'));
                    LibFile.Close();
                }
            }
            //Записывваем в конечный файл сам скрипт
            FileStream fs = File.OpenRead(Settings.sGetLuaFileName());
            while ((readLen = fs.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsa.Write(buffer, 0, readLen);
                res = true;
            }
            fsa.Close();
            fs.Close();
            return res;
        }
        private bool vCheckLuaFile()
        {
            bool res = false;
            ProcessStartInfo startInfo = new ProcessStartInfo();
            StreamReader outputReader = null;
            StreamReader errorReader = null;
            ConsoleTextBox.AppendText("Начинаем проверку файла: " + Settings.sGetLuaFileName() + Environment.NewLine);
            startInfo.FileName = Settings.sGetUtilPath() + "\\luacheck.exe";
            startInfo.Arguments = " " + Settings.sGetLIBPath() + " -s " + Settings.sGetLuaFileName() + " " + LuaCheckParam;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            Process process = Process.Start(startInfo);
            outputReader = process.StandardOutput;
            errorReader = process.StandardError;
            process.WaitForExit(100);
            String error = outputReader.ReadToEnd();
            String error_parse = error.Substring(error.IndexOf("Total:"));
            int warnings = Int32.Parse(error_parse.Substring(7, (error_parse.IndexOf("warnings") - 7)));
            int errors = Int32.Parse(error_parse.Substring(error_parse.IndexOf("/") + 2, error_parse.IndexOf("error") - error_parse.IndexOf("/") - 2));
            if (errors == 0)
            {
                ConsoleTextBox.AppendText(errorReader.ReadToEnd() + Environment.NewLine);
                ConsoleTextBox.AppendText(error + Environment.NewLine);
                ConsoleTextBox.AppendText("Провекра скрипта выполнена успешно\n" + Environment.NewLine);
                res = true;
            }
            else
            {
                ConsoleTextBox.AppendText(errorReader.ReadToEnd() + Environment.NewLine);
                ConsoleTextBox.AppendText(error + Environment.NewLine);
                ConsoleTextBox.AppendText("В скрипте найдены ошибки\n");
            }
            return res;
        }
        private bool vCompile()
        {
            StatusLine.Text = luacheck_begin_mes;
            bool res = vCheckLuaFile();
            vStatusLinePrint(res ? lualink_begin_mes : luacheck_error_mes, res);
            ConsoleTextBox.ScrollToCaret();
            progressBar1.PerformStep();
            if (res)
            {
                res = vLuaLink();
                vStatusLinePrint(res ? luac_begin_mes : lualink_error_mes, res);
                progressBar1.PerformStep();
                if (res)
                {
                    res = CompileLUA();
                    progressBar1.PerformStep();
                    vStatusLinePrint(res ? byte_code_ok_mes : byte_code_error_mes, res);
                }
            }
            return res;
        }
    }
}
