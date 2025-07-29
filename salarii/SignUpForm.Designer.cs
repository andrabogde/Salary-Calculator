namespace SALARII
{
    partial class SignUpForm
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
            numelbl = new Label();
            prenumelbl = new Label();
            utilizlbl = new Label();
            parolalbl = new Label();
            confpasslbl = new Label();
            numetxt = new TextBox();
            prenumetxt = new TextBox();
            utiliztxt = new TextBox();
            parolatxt = new TextBox();
            confpasstxt = new TextBox();
            signupbtn = new Button();
            loginlink = new LinkLabel();
            SuspendLayout();
            // 
            // numelbl
            // 
            numelbl.AutoSize = true;
            numelbl.Location = new Point(34, 51);
            numelbl.Name = "numelbl";
            numelbl.Size = new Size(40, 15);
            numelbl.TabIndex = 0;
            numelbl.Text = "Nume";
            // 
            // prenumelbl
            // 
            prenumelbl.AutoSize = true;
            prenumelbl.Location = new Point(34, 105);
            prenumelbl.Name = "prenumelbl";
            prenumelbl.Size = new Size(55, 15);
            prenumelbl.TabIndex = 1;
            prenumelbl.Text = "Prenume";
            // 
            // utilizlbl
            // 
            utilizlbl.AutoSize = true;
            utilizlbl.Location = new Point(34, 149);
            utilizlbl.Name = "utilizlbl";
            utilizlbl.Size = new Size(54, 15);
            utilizlbl.TabIndex = 2;
            utilizlbl.Text = "Utilizator";
            // 
            // parolalbl
            // 
            parolalbl.AutoSize = true;
            parolalbl.Location = new Point(34, 197);
            parolalbl.Name = "parolalbl";
            parolalbl.Size = new Size(40, 15);
            parolalbl.TabIndex = 3;
            parolalbl.Text = "Parola";
            // 
            // confpasslbl
            // 
            confpasslbl.AutoSize = true;
            confpasslbl.Location = new Point(34, 241);
            confpasslbl.Name = "confpasslbl";
            confpasslbl.Size = new Size(93, 15);
            confpasslbl.TabIndex = 4;
            confpasslbl.Text = "Confirma parola";
            // 
            // numetxt
            // 
            numetxt.Location = new Point(146, 48);
            numetxt.Name = "numetxt";
            numetxt.Size = new Size(163, 23);
            numetxt.TabIndex = 5;
            numetxt.TextChanged += numetxt_TextChanged;
            // 
            // prenumetxt
            // 
            prenumetxt.Location = new Point(146, 97);
            prenumetxt.Name = "prenumetxt";
            prenumetxt.Size = new Size(163, 23);
            prenumetxt.TabIndex = 6;
            // 
            // utiliztxt
            // 
            utiliztxt.Location = new Point(146, 146);
            utiliztxt.Name = "utiliztxt";
            utiliztxt.Size = new Size(163, 23);
            utiliztxt.TabIndex = 7;
            // 
            // parolatxt
            // 
            parolatxt.Location = new Point(146, 194);
            parolatxt.Name = "parolatxt";
            parolatxt.Size = new Size(163, 23);
            parolatxt.TabIndex = 8;
            parolatxt.UseSystemPasswordChar = true;
            // 
            // confpasstxt
            // 
            confpasstxt.Location = new Point(146, 233);
            confpasstxt.Name = "confpasstxt";
            confpasstxt.Size = new Size(163, 23);
            confpasstxt.TabIndex = 9;
            confpasstxt.UseSystemPasswordChar = true;
            // 
            // signupbtn
            // 
            signupbtn.Location = new Point(194, 278);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(115, 31);
            signupbtn.TabIndex = 10;
            signupbtn.Text = "Inregistreaza-te";
            signupbtn.UseVisualStyleBackColor = true;
            signupbtn.Click += signupbtn_Click;
            // 
            // loginlink
            // 
            loginlink.AutoSize = true;
            loginlink.Location = new Point(152, 327);
            loginlink.Name = "loginlink";
            loginlink.Size = new Size(157, 15);
            loginlink.TabIndex = 11;
            loginlink.TabStop = true;
            loginlink.Text = "Ai deja cont? Conecteaza-te!";
            loginlink.LinkClicked += loginlink_LinkClicked;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 364);
            Controls.Add(loginlink);
            Controls.Add(signupbtn);
            Controls.Add(confpasstxt);
            Controls.Add(parolatxt);
            Controls.Add(utiliztxt);
            Controls.Add(prenumetxt);
            Controls.Add(numetxt);
            Controls.Add(confpasslbl);
            Controls.Add(parolalbl);
            Controls.Add(utilizlbl);
            Controls.Add(prenumelbl);
            Controls.Add(numelbl);
            Name = "SignUpForm";
            Text = "Creare cont";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numelbl;
        private Label prenumelbl;
        private Label utilizlbl;
        private Label parolalbl;
        private Label confpasslbl;
        private TextBox numetxt;
        private TextBox prenumetxt;
        private TextBox utiliztxt;
        private TextBox parolatxt;
        private TextBox confpasstxt;
        private Button signupbtn;
        private LinkLabel loginlink;
    }
}