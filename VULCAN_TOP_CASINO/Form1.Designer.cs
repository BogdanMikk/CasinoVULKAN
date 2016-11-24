namespace VULCAN_TOP_CASINO
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbCasinoName = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbCasinoName
            // 
            this.LbCasinoName.AutoSize = true;
            this.LbCasinoName.Font = new System.Drawing.Font("Blackadder ITC", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbCasinoName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LbCasinoName.Location = new System.Drawing.Point(181, 9);
            this.LbCasinoName.Name = "LbCasinoName";
            this.LbCasinoName.Size = new System.Drawing.Size(447, 82);
            this.LbCasinoName.TabIndex = 0;
            this.LbCasinoName.Text = "Welcome to Casino";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(278, 94);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(125, 35);
            this.btLogin.TabIndex = 1;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(409, 94);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(125, 35);
            this.btRegister.TabIndex = 1;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 512);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.LbCasinoName);
            this.MaximumSize = new System.Drawing.Size(850, 550);
            this.MinimumSize = new System.Drawing.Size(850, 550);
            this.Name = "MainForm";
            this.Text = "Casino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbCasinoName;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btRegister;
    }
}

