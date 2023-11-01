namespace WindowsFormsApp1
{
    partial class RegisteEnterDATA
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
            this.cbDataType = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtDataEnter = new System.Windows.Forms.MaskedTextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbDataType
            // 
            this.cbDataType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDataType.FormattingEnabled = true;
            this.cbDataType.Location = new System.Drawing.Point(105, 40);
            this.cbDataType.Name = "cbDataType";
            this.cbDataType.Size = new System.Drawing.Size(196, 33);
            this.cbDataType.TabIndex = 0;
            this.cbDataType.SelectedIndexChanged += new System.EventHandler(this.cbDataType_SelectedIndexChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(29, 213);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(343, 51);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Ввести данные";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(29, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDataEnter
            // 
            this.txtDataEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDataEnter.Location = new System.Drawing.Point(60, 112);
            this.txtDataEnter.Mask = "00/00/0000 00:00:00";
            this.txtDataEnter.Name = "txtDataEnter";
            this.txtDataEnter.Size = new System.Drawing.Size(278, 34);
            this.txtDataEnter.TabIndex = 64;
            this.txtDataEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error_label.Location = new System.Drawing.Point(73, 173);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(265, 20);
            this.error_label.TabIndex = 65;
            this.error_label.Text = "Ошибка в формате даннных!!!";
            // 
            // RegisteEnterDATA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 344);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.txtDataEnter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbDataType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisteEnterDATA";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisteEnterDATA";
            this.Load += new System.EventHandler(this.RegisteEnterDATA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDataType;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox txtDataEnter;
        private System.Windows.Forms.Label error_label;
    }
}