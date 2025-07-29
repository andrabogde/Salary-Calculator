namespace SALARII
{
    partial class Form1
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
            numelbl = new Label();
            numetxt = new TextBox();
            salariulbl = new Label();
            zilelbl = new Label();
            orelbl = new Label();
            salariutxt = new TextBox();
            zilelcrtxt = new TextBox();
            orelucrtxt = new TextBox();
            anulezbtn = new Button();
            calcbtn = new Button();
            salariurealizatlbl = new Label();
            salreztxt = new TextBox();
            oreZilbl = new Label();
            oreZitxt = new TextBox();
            caslbl = new Label();
            casslbl = new Label();
            impozitlbl = new Label();
            salnetlbl = new Label();
            castxt = new TextBox();
            casstxt = new TextBox();
            impozittxt = new TextBox();
            salnettxt = new TextBox();
            perstxt = new TextBox();
            perslbl = new Label();
            deduceretxt = new TextBox();
            deducerelbl = new Label();
            dateangjbtn = new Button();
            SuspendLayout();
            // 
            // numelbl
            // 
            numelbl.AutoSize = true;
            numelbl.Location = new Point(12, 62);
            numelbl.Name = "numelbl";
            numelbl.Size = new Size(82, 15);
            numelbl.TabIndex = 0;
            numelbl.Text = "Nume angajat";
            // 
            // numetxt
            // 
            numetxt.Location = new Point(167, 54);
            numetxt.Name = "numetxt";
            numetxt.Size = new Size(166, 23);
            numetxt.TabIndex = 1;
            numetxt.TextChanged += numetxt_TextChanged;
            // 
            // salariulbl
            // 
            salariulbl.AutoSize = true;
            salariulbl.Location = new Point(12, 102);
            salariulbl.Name = "salariulbl";
            salariulbl.Size = new Size(85, 15);
            salariulbl.TabIndex = 2;
            salariulbl.Text = "Salariu de baza";
            // 
            // zilelbl
            // 
            zilelbl.AutoSize = true;
            zilelbl.Location = new Point(12, 148);
            zilelbl.Name = "zilelbl";
            zilelbl.Size = new Size(123, 15);
            zilelbl.TabIndex = 3;
            zilelbl.Text = "Numar zile lucratoare ";
            // 
            // orelbl
            // 
            orelbl.AutoSize = true;
            orelbl.Location = new Point(12, 228);
            orelbl.Name = "orelbl";
            orelbl.Size = new Size(103, 15);
            orelbl.TabIndex = 4;
            orelbl.Text = "Numar ore lucrate";
            // 
            // salariutxt
            // 
            salariutxt.Location = new Point(167, 99);
            salariutxt.Name = "salariutxt";
            salariutxt.Size = new Size(166, 23);
            salariutxt.TabIndex = 5;
            salariutxt.TextChanged += salariutxt_TextChanged;
            // 
            // zilelcrtxt
            // 
            zilelcrtxt.Location = new Point(167, 140);
            zilelcrtxt.Name = "zilelcrtxt";
            zilelcrtxt.Size = new Size(166, 23);
            zilelcrtxt.TabIndex = 6;
            zilelcrtxt.TextChanged += zilelcrtxt_TextChanged;
            // 
            // orelucrtxt
            // 
            orelucrtxt.Location = new Point(167, 225);
            orelucrtxt.Name = "orelucrtxt";
            orelucrtxt.Size = new Size(166, 23);
            orelucrtxt.TabIndex = 7;
            orelucrtxt.TextChanged += orelucrtxt_TextChanged;
            // 
            // anulezbtn
            // 
            anulezbtn.Location = new Point(476, 390);
            anulezbtn.Name = "anulezbtn";
            anulezbtn.Size = new Size(100, 26);
            anulezbtn.TabIndex = 8;
            anulezbtn.Text = "Anuleaza";
            anulezbtn.UseVisualStyleBackColor = true;
            anulezbtn.Click += anulezbtn_Click;
            // 
            // calcbtn
            // 
            calcbtn.Location = new Point(632, 390);
            calcbtn.Name = "calcbtn";
            calcbtn.Size = new Size(105, 26);
            calcbtn.TabIndex = 9;
            calcbtn.Text = "Salveaza";
            calcbtn.UseVisualStyleBackColor = true;
            calcbtn.Click += calcbtn_Click;
            // 
            // salariurealizatlbl
            // 
            salariurealizatlbl.AutoSize = true;
            salariurealizatlbl.Location = new Point(12, 279);
            salariurealizatlbl.Name = "salariurealizatlbl";
            salariurealizatlbl.Size = new Size(82, 15);
            salariurealizatlbl.TabIndex = 10;
            salariurealizatlbl.Text = "Salariu realizat";
            // 
            // salreztxt
            // 
            salreztxt.Location = new Point(167, 276);
            salreztxt.Name = "salreztxt";
            salreztxt.Size = new Size(166, 23);
            salreztxt.TabIndex = 11;
            salreztxt.TextChanged += salreztxt_TextChanged;
            // 
            // oreZilbl
            // 
            oreZilbl.AutoSize = true;
            oreZilbl.Location = new Point(12, 188);
            oreZilbl.Name = "oreZilbl";
            oreZilbl.Size = new Size(53, 15);
            oreZilbl.TabIndex = 12;
            oreZilbl.Text = "Ore pe zi";
            // 
            // oreZitxt
            // 
            oreZitxt.Location = new Point(167, 180);
            oreZitxt.Name = "oreZitxt";
            oreZitxt.Size = new Size(166, 23);
            oreZitxt.TabIndex = 13;
            oreZitxt.TextChanged += oreZitxt_TextChanged;
            // 
            // caslbl
            // 
            caslbl.AutoSize = true;
            caslbl.Location = new Point(441, 151);
            caslbl.Name = "caslbl";
            caslbl.Size = new Size(73, 15);
            caslbl.TabIndex = 14;
            caslbl.Text = "Procent CAS";
            // 
            // casslbl
            // 
            casslbl.AutoSize = true;
            casslbl.Location = new Point(441, 105);
            casslbl.Name = "casslbl";
            casslbl.Size = new Size(79, 15);
            casslbl.TabIndex = 15;
            casslbl.Text = "Procent CASS";
            // 
            // impozitlbl
            // 
            impozitlbl.AutoSize = true;
            impozitlbl.Location = new Point(441, 244);
            impozitlbl.Name = "impozitlbl";
            impozitlbl.Size = new Size(47, 15);
            impozitlbl.TabIndex = 16;
            impozitlbl.Text = "Impozit";
            // 
            // salnetlbl
            // 
            salnetlbl.AutoSize = true;
            salnetlbl.Location = new Point(441, 288);
            salnetlbl.Name = "salnetlbl";
            salnetlbl.Size = new Size(62, 15);
            salnetlbl.TabIndex = 17;
            salnetlbl.Text = "Salariu net";
            // 
            // castxt
            // 
            castxt.Location = new Point(579, 148);
            castxt.Name = "castxt";
            castxt.Size = new Size(158, 23);
            castxt.TabIndex = 18;
            castxt.TextChanged += castxt_TextChanged;
            // 
            // casstxt
            // 
            casstxt.Location = new Point(579, 105);
            casstxt.Name = "casstxt";
            casstxt.Size = new Size(158, 23);
            casstxt.TabIndex = 19;
            casstxt.TextChanged += casstxt_TextChanged;
            // 
            // impozittxt
            // 
            impozittxt.Location = new Point(579, 236);
            impozittxt.Name = "impozittxt";
            impozittxt.Size = new Size(158, 23);
            impozittxt.TabIndex = 20;
            impozittxt.TextChanged += impozittxt_TextChanged;
            // 
            // salnettxt
            // 
            salnettxt.Location = new Point(579, 285);
            salnettxt.Name = "salnettxt";
            salnettxt.Size = new Size(158, 23);
            salnettxt.TabIndex = 21;
            salnettxt.TextChanged += salnettxt_TextChanged;
            // 
            // perstxt
            // 
            perstxt.Location = new Point(579, 59);
            perstxt.Name = "perstxt";
            perstxt.Size = new Size(158, 23);
            perstxt.TabIndex = 22;
            perstxt.TextChanged += perstxt_TextChanged;
            // 
            // perslbl
            // 
            perslbl.AutoSize = true;
            perslbl.Location = new Point(441, 62);
            perslbl.Name = "perslbl";
            perslbl.Size = new Size(113, 15);
            perslbl.TabIndex = 23;
            perslbl.Text = "Persoane intretinute";
            // 
            // deduceretxt
            // 
            deduceretxt.Location = new Point(579, 193);
            deduceretxt.Name = "deduceretxt";
            deduceretxt.Size = new Size(158, 23);
            deduceretxt.TabIndex = 24;
            deduceretxt.TextChanged += deduceretxt_TextChanged;
            // 
            // deducerelbl
            // 
            deducerelbl.AutoSize = true;
            deducerelbl.Location = new Point(441, 196);
            deducerelbl.Name = "deducerelbl";
            deducerelbl.Size = new Size(111, 15);
            deducerelbl.TabIndex = 25;
            deducerelbl.Text = "Deducere personala";
            // 
            // dateangjbtn
            // 
            dateangjbtn.Location = new Point(12, 393);
            dateangjbtn.Name = "dateangjbtn";
            dateangjbtn.Size = new Size(130, 23);
            dateangjbtn.TabIndex = 27;
            dateangjbtn.Text = "Detalii";
            dateangjbtn.UseVisualStyleBackColor = true;
            dateangjbtn.Click += dateangjbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 450);
            Controls.Add(dateangjbtn);
            Controls.Add(deducerelbl);
            Controls.Add(deduceretxt);
            Controls.Add(perslbl);
            Controls.Add(perstxt);
            Controls.Add(salnettxt);
            Controls.Add(impozittxt);
            Controls.Add(casstxt);
            Controls.Add(castxt);
            Controls.Add(salnetlbl);
            Controls.Add(impozitlbl);
            Controls.Add(casslbl);
            Controls.Add(caslbl);
            Controls.Add(oreZitxt);
            Controls.Add(oreZilbl);
            Controls.Add(salreztxt);
            Controls.Add(salariurealizatlbl);
            Controls.Add(calcbtn);
            Controls.Add(anulezbtn);
            Controls.Add(orelucrtxt);
            Controls.Add(zilelcrtxt);
            Controls.Add(salariutxt);
            Controls.Add(orelbl);
            Controls.Add(zilelbl);
            Controls.Add(salariulbl);
            Controls.Add(numetxt);
            Controls.Add(numelbl);
            Name = "Form1";
            Text = "Calcul Salarii";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label numelbl;
        private TextBox numetxt;
        private Label salariulbl;
        private Label zilelbl;
        private Label orelbl;
        private TextBox salariutxt;
        private TextBox zilelcrtxt;
        private TextBox orelucrtxt;
        private Button anulezbtn;
        private Button calcbtn;
        private Label salariurealizatlbl;
        private TextBox salreztxt;
        private Label oreZilbl;
        private TextBox oreZitxt;
        private Label caslbl;
        private Label casslbl;
        private Label impozitlbl;
        private Label salnetlbl;
        private TextBox castxt;
        private TextBox casstxt;
        private TextBox impozittxt;
        private TextBox salnettxt;
        private TextBox perstxt;
        private Label perslbl;
        private TextBox deduceretxt;
        private Label deducerelbl;
        private Button dateangjbtn;
    }
}
