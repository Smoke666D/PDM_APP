namespace WindowsFormsApp1
{
    partial class PassworForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassworForm));
            this.txtPas = new System.Windows.Forms.TextBox();
            this.btnAcces = new System.Windows.Forms.Button();
            this.pasInformLebel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPas
            // 
            this.txtPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPas.Location = new System.Drawing.Point(78, 90);
            this.txtPas.MaxLength = 5;
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(126, 30);
            this.txtPas.TabIndex = 0;
            // 
            // btnAcces
            // 
            this.btnAcces.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAcces.BackgroundImage")));
            this.btnAcces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcces.Location = new System.Drawing.Point(46, 140);
            this.btnAcces.Name = "btnAcces";
            this.btnAcces.Size = new System.Drawing.Size(182, 53);
            this.btnAcces.TabIndex = 1;
            this.btnAcces.UseVisualStyleBackColor = true;
            this.btnAcces.Click += new System.EventHandler(this.btnAcces_Click);
            // 
            // pasInformLebel
            // 
            this.pasInformLebel.AutoSize = true;
            this.pasInformLebel.Location = new System.Drawing.Point(66, 23);
            this.pasInformLebel.Name = "pasInformLebel";
            this.pasInformLebel.Size = new System.Drawing.Size(138, 16);
            this.pasInformLebel.TabIndex = 2;
            this.pasInformLebel.Text = "Ведите код доступа";
            this.pasInformLebel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "(цифра от 1 до 65536)";
            // 
            // PassworForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 216);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pasInformLebel);
            this.Controls.Add(this.btnAcces);
            this.Controls.Add(this.txtPas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PassworForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Код доступа к устройству";
            this.Shown += new System.EventHandler(this.PassworForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Button btnAcces;
        private System.Windows.Forms.Label pasInformLebel;
        private System.Windows.Forms.Label label1;
    }
}