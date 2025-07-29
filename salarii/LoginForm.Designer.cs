namespace SALARII
{
    partial class LoginForm
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
            utilizatorlbl = new Label();
            parolalbl = new Label();
            utilizatortxt = new TextBox();
            parolatxt = new TextBox();
            signuplink = new LinkLabel();
            forgotpasslink = new LinkLabel();
            loginbtn = new Button();
            SuspendLayout();
            // 
            // utilizatorlbl
            // 
            utilizatorlbl.AutoSize = true;
            utilizatorlbl.Location = new Point(43, 59);
            utilizatorlbl.Name = "utilizatorlbl";
            utilizatorlbl.Size = new Size(54, 15);
            utilizatorlbl.TabIndex = 0;
            utilizatorlbl.Text = "Utilizator";
            // 
            // parolalbl
            // 
            parolalbl.AutoSize = true;
            parolalbl.Location = new Point(43, 121);
            parolalbl.Name = "parolalbl";
            parolalbl.Size = new Size(40, 15);
            parolalbl.TabIndex = 1;
            parolalbl.Text = "Parola";
            // 
            // utilizatortxt
            // 
            utilizatortxt.Location = new Point(130, 59);
            utilizatortxt.Name = "utilizatortxt";
            utilizatortxt.Size = new Size(217, 23);
            utilizatortxt.TabIndex = 2;
            utilizatortxt.TextChanged += utilizatortxt_TextChanged;
            // 
            // parolatxt
            // 
            parolatxt.Location = new Point(130, 113);
            parolatxt.Name = "parolatxt";
            parolatxt.Size = new Size(217, 23);
            parolatxt.TabIndex = 3;
            parolatxt.UseSystemPasswordChar = true;
            parolatxt.TextChanged += parolatxt_TextChanged;
            // 
            // signuplink
            // 
            signuplink.AutoSize = true;
            signuplink.Location = new Point(272, 230);
            signuplink.Name = "signuplink";
            signuplink.Size = new Size(75, 15);
            signuplink.TabIndex = 4;
            signuplink.TabStop = true;
            signuplink.Text = "Creeaza cont";
            signuplink.LinkClicked += linkLabel1_LinkClicked;
            // 
            // forgotpasslink
            // 
            forgotpasslink.ActiveLinkColor = Color.RoyalBlue;
            forgotpasslink.AutoSize = true;
            forgotpasslink.LinkColor = Color.Red;
            forgotpasslink.Location = new Point(8, 230);
            forgotpasslink.Name = "forgotpasslink";
            forgotpasslink.Size = new Size(89, 15);
            forgotpasslink.TabIndex = 5;
            forgotpasslink.TabStop = true;
            forgotpasslink.Text = "Am uitat parola";
            forgotpasslink.LinkClicked += forgotpasslink_LinkClicked;
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(254, 169);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(93, 27);
            loginbtn.TabIndex = 6;
            loginbtn.Text = "Conecteaza-te";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 274);
            Controls.Add(loginbtn);
            Controls.Add(forgotpasslink);
            Controls.Add(signuplink);
            Controls.Add(parolatxt);
            Controls.Add(utilizatortxt);
            Controls.Add(parolalbl);
            Controls.Add(utilizatorlbl);
            Name = "LoginForm";
            Text = "Conectare cont";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label utilizatorlbl;
        private Label parolalbl;
        private TextBox utilizatortxt;
        private TextBox parolatxt;
        private LinkLabel signuplink;
        private LinkLabel forgotpasslink;
        private Button loginbtn;
    }
}