namespace SALARII
{
    partial class ForgotPassForm
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
            label1 = new Label();
            label2 = new Label();
            emailtxt = new TextBox();
            button1 = new Button();
            parolatxt = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 56);
            label1.Name = "label1";
            label1.Size = new Size(568, 17);
            label1.TabIndex = 0;
            label1.Text = "Ai uitat parola? Introdu emailul si vei primi un cod de confirmare pentru resetarea parolei.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 120);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // emailtxt
            // 
            emailtxt.Location = new Point(317, 112);
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(172, 23);
            emailtxt.TabIndex = 3;
            emailtxt.TextChanged += emailtxt_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(363, 220);
            button1.Name = "button1";
            button1.Size = new Size(126, 30);
            button1.TabIndex = 5;
            button1.Text = "Reseteaza parola";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // parolatxt
            // 
            parolatxt.Location = new Point(317, 167);
            parolatxt.Name = "parolatxt";
            parolatxt.Size = new Size(172, 23);
            parolatxt.TabIndex = 4;
            parolatxt.TextChanged += parolatxt_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 175);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Noua Parola";
            // 
            // ForgotPassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 276);
            Controls.Add(button1);
            Controls.Add(parolatxt);
            Controls.Add(emailtxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ForgotPassForm";
            Text = "Resetare parola";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox emailtxt;
        private Button button1;
        private TextBox parolatxt;
        private Label label3;
    }
}