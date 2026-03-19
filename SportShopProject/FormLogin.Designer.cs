namespace SportShopProject
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pictureBoxLogin = new PictureBox();
            panelLogin = new Panel();
            buttonLoginGuest = new Button();
            labelPass = new Label();
            textBoxPassword = new TextBox();
            textBoxLogin = new TextBox();
            labelLog = new Label();
            buttonLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            pictureBoxLogin.Anchor = AnchorStyles.None;
            pictureBoxLogin.Image = (Image)resources.GetObject("pictureBoxLogin.Image");
            pictureBoxLogin.Location = new Point(180, 17);
            pictureBoxLogin.Margin = new Padding(4);
            pictureBoxLogin.Name = "pictureBoxLogin";
            pictureBoxLogin.Size = new Size(257, 252);
            pictureBoxLogin.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogin.TabIndex = 0;
            pictureBoxLogin.TabStop = false;
            // 
            // panelLogin
            // 
            panelLogin.Controls.Add(buttonLoginGuest);
            panelLogin.Controls.Add(labelPass);
            panelLogin.Controls.Add(textBoxPassword);
            panelLogin.Controls.Add(textBoxLogin);
            panelLogin.Controls.Add(labelLog);
            panelLogin.Controls.Add(buttonLogin);
            panelLogin.Location = new Point(93, 276);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(422, 295);
            panelLogin.TabIndex = 7;
            // 
            // buttonLoginGuest
            // 
            buttonLoginGuest.BackColor = Color.FromArgb(233, 245, 255);
            buttonLoginGuest.FlatStyle = FlatStyle.Flat;
            buttonLoginGuest.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLoginGuest.ForeColor = Color.Black;
            buttonLoginGuest.Location = new Point(55, 230);
            buttonLoginGuest.Margin = new Padding(4);
            buttonLoginGuest.Name = "buttonLoginGuest";
            buttonLoginGuest.Size = new Size(314, 56);
            buttonLoginGuest.TabIndex = 12;
            buttonLoginGuest.Text = "Войти как гость";
            buttonLoginGuest.UseVisualStyleBackColor = false;
            buttonLoginGuest.Click += ButtonLoginGuest_Click;
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelPass.Location = new Point(54, 84);
            labelPass.Margin = new Padding(4, 0, 4, 0);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(69, 21);
            labelPass.TabIndex = 11;
            labelPass.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxPassword.Location = new Point(55, 109);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(313, 29);
            textBoxPassword.TabIndex = 10;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxLogin.Location = new Point(55, 33);
            textBoxLogin.Margin = new Padding(4);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(313, 29);
            textBoxLogin.TabIndex = 9;
            // 
            // labelLog
            // 
            labelLog.AutoSize = true;
            labelLog.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelLog.Location = new Point(54, 8);
            labelLog.Margin = new Padding(4, 0, 4, 0);
            labelLog.Name = "labelLog";
            labelLog.Size = new Size(61, 21);
            labelLog.TabIndex = 8;
            labelLog.Text = "Логин";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(67, 97, 238);
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(54, 162);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(314, 56);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "Вход";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += ButtonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(620, 575);
            Controls.Add(panelLogin);
            Controls.Add(pictureBoxLogin);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogin).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxLogin;
        private Panel panelLogin;
        private Button buttonLoginGuest;
        private Label labelPass;
        private TextBox textBoxPassword;
        private TextBox textBoxLogin;
        private Label labelLog;
        private Button buttonLogin;
    }
}
