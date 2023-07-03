using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{

    
    class AppSettings
    {
        private string LUAUtilityPath;
        public bool UtilityPathValid;
        private string LIBPath;
        public bool LIBPathValid;
        private string LuacFileName;
        public bool LuacFileNameValid;
        private string LuaFileName;
        public bool LuaFileNameValid;
        private Settings APPData;

   
        private bool bIsLIBPathValid(string path)
        {
            bool res = false;
            if (Directory.Exists(path))
            {
                var txtFiles = Directory.EnumerateFiles(path, "*.lua");
                if (txtFiles.Count() > 0)
                {
                    res = true;
                }
            }
            return res;
        }
        private bool bIsUtiliryPathValid(string path)
        {
            bool res = false;
            if (Directory.Exists(path))
            {
               if ( File.Exists(path + "\\luac.exe") & (File.Exists(path +"\\luacheck.exe")))
                {
                    res = true;
                }
            }
            return res;
        }
        public void Dispose()
        {
           APPData.Save();
        }
        public AppSettings()
        {
            string sName;
            APPData = new Settings();
            if (bIsUtiliryPathValid(APPData.LUAUtilityPath) == true)
            {
                LUAUtilityPath = APPData.LUAUtilityPath;
                UtilityPathValid = true;
            }
            else
            {
                sName = Directory.GetCurrentDirectory() + "\\UTIL";
                UtilityPathValid = bIsUtiliryPathValid(sName);
                LUAUtilityPath = UtilityPathValid ? sName : "";
            }
            if (bIsLIBPathValid(APPData.LIBLUAPath) == true)
            {
                LIBPath = APPData.LIBLUAPath;
                LIBPathValid = true;
            }
            else
            {
                sName = Directory.GetCurrentDirectory() + "\\lib";
                LIBPathValid = bIsLIBPathValid(sName);
                LIBPath = LIBPathValid ? sName : "";
            }

            LuacFileNameValid = File.Exists(APPData.LuacFile);
            if (LuacFileNameValid == true)
            { 
                LuacFileName = APPData.LuacFile;
            }
            else
            {
                sName = Directory.GetCurrentDirectory() + "\\out.luac";
                LuacFileNameValid = File.Exists(sName); ;
                LuacFileName = LuacFileNameValid ? sName : "";
            }
            LuaFileNameValid = File.Exists(APPData.LuaFile);
            if (LuaFileNameValid == true)
            {
                LuaFileName = APPData.LuaFile;
            }


        }
        public bool vSetUtilityPath(string LuaUtilPath)
        {
            bool res = false;
            if (bIsUtiliryPathValid(LuaUtilPath) == true)
            {
                LUAUtilityPath = LuaUtilPath;
                APPData.LUAUtilityPath = LuaUtilPath;
                UtilityPathValid = true;
                res = true;
            }
            return res;
        }
        public string sGetUtilityPath() 
        {
            return LUAUtilityPath;
        }
        public bool vSetLIBPath(string Path)
        {
            LIBPath = Path;
            APPData.LIBLUAPath = Path;
            LIBPathValid = bIsLIBPathValid(Path);
            return LIBPathValid;
        }

        public bool vSetLUAFile( string Name)
        {
            bool res = false;
            if (File.Exists(Name) == true)
            {
                LuaFileName = Name;
                APPData.LuaFile = Name;
                LuaFileNameValid = true;
            }
            else
            {
                LuaFileNameValid = false;

            }
            return res;
        }
        public bool vSetLUACFile(string Name)
        {
            bool res = false;
            if ( File.Exists(Name) == true ) 
            { 
                LuacFileName = Name;
                APPData.LuacFile = Name;
                LuacFileNameValid = true;
            }
            else
            {
                Name = Directory.GetCurrentDirectory() + "\\" + "out.luac";
                if (File.Exists(Name) == true)
                {
                    LuacFileName = Name;
                    APPData.LuacFile = Name;
                    LuacFileNameValid = true;
                }
                else
                    LuacFileNameValid =false;   

            }
            return res;
        }
        public string sGetLuaFileName()
        { return LuaFileName; }
        public string sGetLUACFileName()
        { return LuacFileName; }
        public string sGetLIBPath()
        { 
            return LIBPath; 
        }
        public string sGetUtilPath()
        {
            return LUAUtilityPath;
        }
            
    }
}
