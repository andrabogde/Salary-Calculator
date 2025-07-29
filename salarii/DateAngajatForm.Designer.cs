namespace SALARII
{
    partial class DateAngajatForm
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
            sal1txt = new TextBox();
            sal2txt = new TextBox();
            sal3txt = new TextBox();
            sal4txt = new TextBox();
            sal5txt = new TextBox();
            sal6txt = new TextBox();
            salariilbl = new Label();
            weeklbl = new Label();
            noaptelbl = new Label();
            noaptetxt = new TextBox();
            salbtn = new Button();
            anlbtn = new Button();
            colbl = new Label();
            cocmb = new ComboBox();
            dsfarsitlbl = new Label();
            dsfarsittxt = new TextBox();
            monthCalendar2 = new MonthCalendar();
            sportxt = new TextBox();
            nrzile6lbl = new Label();
            nrzile6txt = new TextBox();
            label1 = new Label();
            retinerichklst = new CheckedListBox();
            caracperlbl = new Label();
            caracperchklist = new CheckedListBox();
            SuspendLayout();
            // 
            // sal1txt
            // 
            sal1txt.Location = new Point(691, 99);
            sal1txt.Name = "sal1txt";
            sal1txt.Size = new Size(121, 23);
            sal1txt.TabIndex = 2;
            sal1txt.TextChanged += sal1txt_TextChanged;
            sal1txt.KeyPress += sal1txt_TextChanged;
            // 
            // sal2txt
            // 
            sal2txt.Location = new Point(691, 141);
            sal2txt.Name = "sal2txt";
            sal2txt.Size = new Size(121, 23);
            sal2txt.TabIndex = 3;
            sal2txt.TextChanged += sal2txt_TextChanged;
            // 
            // sal3txt
            // 
            sal3txt.Location = new Point(691, 185);
            sal3txt.Name = "sal3txt";
            sal3txt.Size = new Size(121, 23);
            sal3txt.TabIndex = 4;
            sal3txt.TextChanged += sal3txt_TextChanged;
            // 
            // sal4txt
            // 
            sal4txt.Location = new Point(691, 223);
            sal4txt.Name = "sal4txt";
            sal4txt.Size = new Size(121, 23);
            sal4txt.TabIndex = 5;
            sal4txt.TextChanged += sal4txt_TextChanged;
            // 
            // sal5txt
            // 
            sal5txt.Location = new Point(691, 264);
            sal5txt.Name = "sal5txt";
            sal5txt.Size = new Size(121, 23);
            sal5txt.TabIndex = 6;
            sal5txt.TextChanged += sal5txt_TextChanged;
            // 
            // sal6txt
            // 
            sal6txt.Location = new Point(691, 302);
            sal6txt.Name = "sal6txt";
            sal6txt.Size = new Size(121, 23);
            sal6txt.TabIndex = 7;
            sal6txt.TextChanged += sal6txt_TextChanged;
            // 
            // salariilbl
            // 
            salariilbl.AutoSize = true;
            salariilbl.Location = new Point(543, 107);
            salariilbl.Name = "salariilbl";
            salariilbl.Size = new Size(123, 15);
            salariilbl.TabIndex = 8;
            salariilbl.Text = "Salariu ultimele 6 luni:";
            // 
            // weeklbl
            // 
            weeklbl.AutoSize = true;
            weeklbl.Location = new Point(37, 363);
            weeklbl.Name = "weeklbl";
            weeklbl.Size = new Size(81, 15);
            weeklbl.TabIndex = 10;
            weeklbl.Text = "Spor weekend";
            // 
            // noaptelbl
            // 
            noaptelbl.AutoSize = true;
            noaptelbl.Location = new Point(37, 403);
            noaptelbl.Name = "noaptelbl";
            noaptelbl.Size = new Size(149, 15);
            noaptelbl.TabIndex = 13;
            noaptelbl.Text = "Numar ore lucrate noaptea";
            // 
            // noaptetxt
            // 
            noaptetxt.Location = new Point(192, 400);
            noaptetxt.Name = "noaptetxt";
            noaptetxt.Size = new Size(121, 23);
            noaptetxt.TabIndex = 14;
            noaptetxt.TextChanged += noaptetxt_TextChanged;
            // 
            // salbtn
            // 
            salbtn.Location = new Point(711, 490);
            salbtn.Name = "salbtn";
            salbtn.Size = new Size(101, 29);
            salbtn.TabIndex = 15;
            salbtn.Text = "Salveaza";
            salbtn.UseVisualStyleBackColor = true;
            salbtn.Click += salbtn_Click;
            // 
            // anlbtn
            // 
            anlbtn.Location = new Point(21, 490);
            anlbtn.Name = "anlbtn";
            anlbtn.Size = new Size(102, 29);
            anlbtn.TabIndex = 16;
            anlbtn.Text = "Anuleaza";
            anlbtn.UseVisualStyleBackColor = true;
            anlbtn.Click += anlbtn_Click;
            // 
            // colbl
            // 
            colbl.AutoSize = true;
            colbl.Location = new Point(37, 46);
            colbl.Name = "colbl";
            colbl.Size = new Size(61, 15);
            colbl.TabIndex = 19;
            colbl.Text = "Concediu ";
            // 
            // cocmb
            // 
            cocmb.FormattingEnabled = true;
            cocmb.Items.AddRange(new object[] { "Concediu de odihna", "Concediu medical" });
            cocmb.Location = new Point(193, 38);
            cocmb.Name = "cocmb";
            cocmb.Size = new Size(247, 23);
            cocmb.TabIndex = 20;
            cocmb.Text = "--Alegeti tipul concediului!--";
            cocmb.SelectedIndexChanged += cocmb_SelectedIndexChanged;
            // 
            // dsfarsitlbl
            // 
            dsfarsitlbl.AutoSize = true;
            dsfarsitlbl.Location = new Point(37, 86);
            dsfarsitlbl.Name = "dsfarsitlbl";
            dsfarsitlbl.Size = new Size(118, 15);
            dsfarsitlbl.TabIndex = 23;
            dsfarsitlbl.Text = "Perioada concediului";
            // 
            // dsfarsittxt
            // 
            dsfarsittxt.Location = new Point(192, 244);
            dsfarsittxt.Name = "dsfarsittxt";
            dsfarsittxt.Size = new Size(248, 23);
            dsfarsittxt.TabIndex = 24;
            dsfarsittxt.TextChanged += dsfarsittxt_TextChanged;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(192, 86);
            monthCalendar2.MaxSelectionCount = 30;
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 27;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // sportxt
            // 
            sportxt.Location = new Point(192, 360);
            sportxt.Name = "sportxt";
            sportxt.Size = new Size(121, 23);
            sportxt.TabIndex = 28;
            sportxt.TextChanged += sportxt_TextChanged;
            // 
            // nrzile6lbl
            // 
            nrzile6lbl.AutoSize = true;
            nrzile6lbl.Location = new Point(465, 46);
            nrzile6lbl.Name = "nrzile6lbl";
            nrzile6lbl.Size = new Size(201, 15);
            nrzile6lbl.TabIndex = 29;
            nrzile6lbl.Text = "Nr zilelor lucratoare in ultimele 6 luni";
            // 
            // nrzile6txt
            // 
            nrzile6txt.Location = new Point(691, 38);
            nrzile6txt.Name = "nrzile6txt";
            nrzile6txt.Size = new Size(121, 23);
            nrzile6txt.TabIndex = 30;
            nrzile6txt.TextChanged += nrzile6txt_TextChanged;
            nrzile6txt.KeyPress += sal1txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 298);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 31;
            label1.Text = "Retineri";
            // 
            // retinerichklst
            // 
            retinerichklst.FormattingEnabled = true;
            retinerichklst.Items.AddRange(new object[] { "POPRIRE - 1%", "SALARIU IN AVANS - 5%", "INTARZIERE - 2%", "CONCEDIU IN AVANS - 5%" });
            retinerichklst.Location = new Point(192, 282);
            retinerichklst.Name = "retinerichklst";
            retinerichklst.Size = new Size(248, 58);
            retinerichklst.TabIndex = 36;
            retinerichklst.ItemCheck += retinerichklst_ItemCheck;
            // 
            // caracperlbl
            // 
            caracperlbl.AutoSize = true;
            caracperlbl.Location = new Point(451, 360);
            caracperlbl.Name = "caracperlbl";
            caracperlbl.Size = new Size(167, 15);
            caracperlbl.TabIndex = 37;
            caracperlbl.Text = "Sporuri cu caracter permanent";
            // 
            // caracperchklist
            // 
            caracperchklist.FormattingEnabled = true;
            caracperchklist.Items.AddRange(new object[] { "VECHIME - 5%", "CONDITII GRELE - 5%", "CONDITII PERICULOASE - 10%" });
            caracperchklist.Location = new Point(624, 360);
            caracperchklist.Name = "caracperchklist";
            caracperchklist.Size = new Size(195, 94);
            caracperchklist.TabIndex = 38;
            caracperchklist.ItemCheck += caracperchklist_ItemCheck;
            // 
            // DateAngajatForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 531);
            Controls.Add(caracperchklist);
            Controls.Add(caracperlbl);
            Controls.Add(retinerichklst);
            Controls.Add(label1);
            Controls.Add(nrzile6txt);
            Controls.Add(nrzile6lbl);
            Controls.Add(sportxt);
            Controls.Add(monthCalendar2);
            Controls.Add(dsfarsittxt);
            Controls.Add(dsfarsitlbl);
            Controls.Add(cocmb);
            Controls.Add(colbl);
            Controls.Add(anlbtn);
            Controls.Add(salbtn);
            Controls.Add(noaptetxt);
            Controls.Add(noaptelbl);
            Controls.Add(weeklbl);
            Controls.Add(salariilbl);
            Controls.Add(sal6txt);
            Controls.Add(sal5txt);
            Controls.Add(sal4txt);
            Controls.Add(sal3txt);
            Controls.Add(sal2txt);
            Controls.Add(sal1txt);
            Name = "DateAngajatForm";
            Text = " Detalii";
            Load += DateAngajatForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox sal1txt;
        private TextBox sal2txt;
        private TextBox sal3txt;
        private TextBox sal4txt;
        private TextBox sal5txt;
        private TextBox sal6txt;
        private Label salariilbl;
        private Label weeklbl;
        private Label noaptelbl;
        private TextBox noaptetxt;
        private Button salbtn;
        private Button anlbtn;
        private Label colbl;
        private ComboBox cocmb;
        private Label dsfarsitlbl;
        private TextBox dsfarsittxt;
        private MonthCalendar monthCalendar2;
        private TextBox sportxt;
        private Label nrzile6lbl;
        private TextBox nrzile6txt;
        private Label label1;
        private CheckedListBox retinerichklst;
        private Label caracperlbl;
        private CheckedListBox caracperchklist;
    }
}