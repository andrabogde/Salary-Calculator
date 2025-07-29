using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace SALARII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            salreztxt.ReadOnly = true;
            salnettxt.ReadOnly = true;
            deduceretxt.ReadOnly = true;
            castxt.ReadOnly = true;
            casstxt.ReadOnly = true;
            impozittxt.ReadOnly = true;
        }
        public double ZileLucrate
        {
            get { return double.Parse(zilelcrtxt.Text); }
        }

        public double OrePeZi
        {
            get { return double.Parse(oreZitxt.Text); }
        }


        public double Salariu
        {
            get { return double.Parse(salariutxt.Text); }
        }
        public string SalRezTxt
        {
            get { return salreztxt.Text; }
            set { salreztxt.Text = value; }
        }


        public double OreLucrate
        {
            get { return double.Parse(orelucrtxt.Text); }
        }


        private void numetxt_TextChanged(object sender, EventArgs e)
        {
            // Salvăm poziția cursorului
            int cursorPosition = numetxt.SelectionStart;

            // Permitem doar litere (majuscule și minuscule)
            string newText = Regex.Replace(numetxt.Text, @"[^a-zA-Z]", "");

            // Dacă s-au efectuat modificări, actualizăm textul
            if (newText != numetxt.Text)
            {
                numetxt.Text = newText;
                // Restaurăm poziția cursorului
                numetxt.SelectionStart = cursorPosition - 1;
            }
        }

        private void salariutxt_TextChanged(object sender, EventArgs e)
        {
            // Salvăm poziția cursorului
            int cursorPosition = salariutxt.SelectionStart;

            // Permitem doar cifre (0-9)
            string newText = Regex.Replace(salariutxt.Text, @"[^0-9]", "");

            // Dacă s-au efectuat modificări, actualizăm textul
            if (newText != salariutxt.Text)
            {
                salariutxt.Text = newText;
                // Restaurăm poziția cursorului
                salariutxt.SelectionStart = cursorPosition - 1;
            }
            RecalcSalariu();
            calculeazaDed();
        }

        private void zilelcrtxt_TextChanged(object sender, EventArgs e)
        {
            // Salvăm poziția cursorului
            int cursorPosition = zilelcrtxt.SelectionStart;

            // Permitem doar cifre (0-9)
            string newText = Regex.Replace(zilelcrtxt.Text, @"[^0-9]", "");

            // Dacă s-au efectuat modificări, actualizăm textul
            if (newText != zilelcrtxt.Text)
            {
                zilelcrtxt.Text = newText;
                // Restaurăm poziția cursorului
                zilelcrtxt.SelectionStart = cursorPosition - 1;
            }
            RecalcSalariu();
        }

        private void orelucrtxt_TextChanged(object sender, EventArgs e)
        {
            // Salvăm poziția cursorului
            int cursorPosition = orelucrtxt.SelectionStart;

            // Permitem doar cifre (0-9)
            string newText = Regex.Replace(orelucrtxt.Text, @"[^0-9]", "");

            // Dacă s-au efectuat modificări, actualizăm textul
            if (newText != orelucrtxt.Text)
            {
                orelucrtxt.Text = newText;
                // Restaurăm poziția cursorului
                orelucrtxt.SelectionStart = cursorPosition - 1;
            }
            RecalcSalariu();
        }

        private void oreZitxt_TextChanged(object sender, EventArgs e)
        {
            // Salvăm poziția cursorului
            int cursorPosition = oreZitxt.SelectionStart;

            // Permitem doar cifre (0-9)
            string newText = Regex.Replace(oreZitxt.Text, @"[^0-9]", "");

            // Dacă s-au efectuat modificări, actualizăm textul
            if (newText != oreZitxt.Text)
            {
                oreZitxt.Text = newText;
                // Restaurăm poziția cursorului
                oreZitxt.SelectionStart = cursorPosition - 1;
            }
            RecalcSalariu();
        }
        public void salreztxt_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(salreztxt.Text, out double salrez);
            double cas = Math.Round(salrez * 0.25);
            castxt.Text = cas.ToString();


            double cass = Math.Round(salrez * 0.10);
            casstxt.Text = cass.ToString();
            calculImpozit();
            calculSalNet();
        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            using (SaveFileForm saveFileDialog = new SaveFileForm())
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Construiește conținutul fișierului
                    string content = $"Nume: {numetxt.Text}\n" +
                                     $"Salariu: {salariutxt.Text}\n" +
                                     $"Ore lucrate: {orelucrtxt.Text}\n" +
                                     $"Salariu rezultat: {salreztxt.Text}\n" +
                                     $"CAS: {castxt.Text}\n" + $"CAS: {casstxt.Text}\n" +
                                     $"Impozit: {impozittxt.Text}\n" +
                                     $"Deducere: {deduceretxt.Text}\n" +
                                     $"Salariu net: {salnettxt.Text}";

                    // Scrie conținutul în fișier
                    File.WriteAllText(filePath, content);

                    MessageBox.Show("Fișierul a fost salvat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void anulezbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }
        private void RecalcSalariu()
        {
            double.TryParse(salariutxt.Text, out double salariu);
            double.TryParse(zilelcrtxt.Text, out double zileLucrate);
            double.TryParse(orelucrtxt.Text, out double oreLucrate); 
                double.TryParse(oreZitxt.Text, out double oreZi);
            double ore = zileLucrate * oreZi;
                double bani = salariu / ore;
                // Calculul salariului rezultat: salariu - (salariu / (zileLucrate * 8)) * oreLucrate
                double salRezultat = bani * oreLucrate;

            if (oreLucrate > ore)
            {
                double x = oreLucrate - ore;
                salRezultat=salRezultat+x*0.75 * bani;
            }
            // Afișăm rezultatul în salreztxt
            salreztxt.Text = salRezultat.ToString();
        }

        private void castxt_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(salreztxt.Text, out double salrez);
            double cas = Math.Round(salrez * 0.25);
            castxt.Text = cas.ToString();
        }

        private void casstxt_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(salreztxt.Text, out double salrez);
            double cass = Math.Round(salrez * 0.10);
            casstxt.Text = cass.ToString();
        }

        private void impozittxt_TextChanged(object sender, EventArgs e)
        {
            calculImpozit();
            calculSalNet();
        }
        private void calculImpozit()
        {
            double salariu, cas, cass, deducere;
            if (double.TryParse(salreztxt.Text, out salariu) &&
            double.TryParse(castxt.Text, out cas) &&
            double.TryParse(casstxt.Text, out cass) &&
            double.TryParse(deduceretxt.Text, out deducere))
            {
                try
                {
                    double impozit = Math.Round((salariu - cas - cass - deducere) * 0.1);
                    impozittxt.Text = impozit.ToString();

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                deduceretxt.Text = "Date invalide";
            }
        }
        private void RecalcSalariuNet()
        {
            if (double.TryParse(castxt.Text, out double cas) &&
                double.TryParse(casstxt.Text, out double cass) &&
                double.TryParse(impozittxt.Text, out double impozit))
            {

                double salRezultat = 0;
                // Afișăm rezultatul în salreztxt
                salnettxt.Text = salRezultat.ToString();
            }
            else
            {
                // Dacă valorile nu sunt valide, ștergem textul din salreztxt
                salnettxt.Text = string.Empty;
            }
        }

        private void salnettxt_TextChanged(object sender, EventArgs e)
        {
            calculSalNet();
        }

        public void calculSalNet()
        {
            double.TryParse(castxt.Text, out double cas);
            double.TryParse(casstxt.Text, out double cass);
            double.TryParse(salreztxt.Text, out double salrez);
            double.TryParse(impozittxt.Text, out double impozit);
            double salNet = salrez - cas - cass - impozit;
            salnettxt.Text = salNet.ToString();
        }
        private void perstxt_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = perstxt.SelectionStart;

            // Permitem doar cifre (0-9)
            string newText = Regex.Replace(perstxt.Text, @"[^0-9]", "");

            // Dacă s-au efectuat modificări, actualizăm textul
            if (newText != perstxt.Text)
            {
                perstxt.Text = newText;
                // Restaurăm poziția cursorului
                perstxt.SelectionStart = cursorPosition - 1;
            }
            calculeazaDed();
            calculImpozit();
            calculSalNet();
        }
        private void calculeazaDed()
        {
            int salariuMinim = 3700;
            int numarPersoaneInIntretinere;
            double salariu;

            // Convertim valorile de text în numere
            if (int.TryParse(perstxt.Text, out numarPersoaneInIntretinere) &&
                double.TryParse(salariutxt.Text, out salariu))
            {
                try
                {
                    double deducere = CalculeazaDeducerea(salariu, salariuMinim, numarPersoaneInIntretinere);
                    double.TryParse(salreztxt.Text, out double salariuRez);
                    double deducereSum = Math.Round(salariuRez * deducere / 100);
                    deduceretxt.Text = deducereSum.ToString();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                deduceretxt.Text = "Date invalide";
            }
            calculImpozit();
        }
        private void deduceretxt_TextChanged(object sender, EventArgs e)
        {

        }

        public static double CalculeazaDeducerea(double salariu, int salariuMinim, int numarPersoaneInIntretinere)
        {
            double deducere = 0.0;

            // Calculează intervalul de deducere
            double salariuMinimPlus = salariu - salariuMinim;

            if (salariu <= salariuMinim)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 20.0; break;
                    case 1: deducere = 25.0; break;
                    case 2: deducere = 30.0; break;
                    case 3: deducere = 35.0; break;
                    default: deducere = 45.0; break;
                }
            }
            else if (salariu <= salariuMinim + 50)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 19.5; break;
                    case 1: deducere = 24.5; break;
                    case 2: deducere = 29.5; break;
                    case 3: deducere = 34.5; break;
                    default: deducere = 44.5; break;
                }
            }
            else if (salariu <= salariuMinim + 100)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 19.0; break;
                    case 1: deducere = 24.0; break;
                    case 2: deducere = 29.0; break;
                    case 3: deducere = 34.0; break;
                    default: deducere = 44.0; break;
                }
            }
            else if (salariu <= salariuMinim + 150)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 18.5; break;
                    case 1: deducere = 23.5; break;
                    case 2: deducere = 28.5; break;
                    case 3: deducere = 33.5; break;
                    default: deducere = 43.5; break;
                }
            }
            else if (salariu <= salariuMinim + 200)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 18.0; break;
                    case 1: deducere = 23.0; break;
                    case 2: deducere = 28.0; break;
                    case 3: deducere = 33.0; break;
                    default: deducere = 43.0; break;
                }
            }
            else if (salariu <= salariuMinim + 250)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 17.5; break;
                    case 1: deducere = 22.5; break;
                    case 2: deducere = 27.5; break;
                    case 3: deducere = 32.5; break;
                    default: deducere = 42.5; break;
                }
            }
            else if (salariu <= salariuMinim + 300)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 17.0; break;
                    case 1: deducere = 22.0; break;
                    case 2: deducere = 27.0; break;
                    case 3: deducere = 32.0; break;
                    default: deducere = 42.0; break;
                }
            }
            else if (salariu <= salariuMinim + 350)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 16.5; break;
                    case 1: deducere = 21.5; break;
                    case 2: deducere = 26.5; break;
                    case 3: deducere = 31.5; break;
                    default: deducere = 41.5; break;
                }
            }
            else if (salariu <= salariuMinim + 400)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 16.0; break;
                    case 1: deducere = 21.0; break;
                    case 2: deducere = 26.0; break;
                    case 3: deducere = 31.0; break;
                    default: deducere = 41.0; break;
                }
            }
            else if (salariu <= salariuMinim + 450)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 15.5; break;
                    case 1: deducere = 20.5; break;
                    case 2: deducere = 25.5; break;
                    case 3: deducere = 30.5; break;
                    default: deducere = 40.5; break;
                }
            }
            else if (salariu <= salariuMinim + 500)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 15.0; break;
                    case 1: deducere = 20.0; break;
                    case 2: deducere = 25.0; break;
                    case 3: deducere = 30.0; break;
                    default: deducere = 40.0; break;
                }
            }
            else if (salariu <= salariuMinim + 550)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 14.5; break;
                    case 1: deducere = 19.5; break;
                    case 2: deducere = 24.5; break;
                    case 3: deducere = 29.5; break;
                    default: deducere = 39.5; break;
                }
            }
            else if (salariu <= salariuMinim + 600)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 14.0; break;
                    case 1: deducere = 19.0; break;
                    case 2: deducere = 24.0; break;
                    case 3: deducere = 29.0; break;
                    default: deducere = 39.0; break;
                }
            }
            else if (salariu <= salariuMinim + 650)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 13.5; break;
                    case 1: deducere = 18.5; break;
                    case 2: deducere = 23.5; break;
                    case 3: deducere = 28.5; break;
                    default: deducere = 38.5; break;
                }
            }
            else if (salariu <= salariuMinim + 700)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 13.0; break;
                    case 1: deducere = 18.0; break;
                    case 2: deducere = 23.0; break;
                    case 3: deducere = 28.0; break;
                    default: deducere = 38.0; break;
                }
            }
            else if (salariu <= salariuMinim + 750)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 12.5; break;
                    case 1: deducere = 17.5; break;
                    case 2: deducere = 22.5; break;
                    case 3: deducere = 27.5; break;
                    default: deducere = 37.5; break;
                }
            }
            else if (salariu <= salariuMinim + 800)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 12.0; break;
                    case 1: deducere = 17.0; break;
                    case 2: deducere = 22.0; break;
                    case 3: deducere = 27.0; break;
                    default: deducere = 37.0; break;
                }
            }
            else if (salariu <= salariuMinim + 850)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 11.5; break;
                    case 1: deducere = 16.5; break;
                    case 2: deducere = 21.5; break;
                    case 3: deducere = 26.5; break;
                    default: deducere = 36.5; break;
                }
            }
            else if (salariu <= salariuMinim + 900)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 11.0; break;
                    case 1: deducere = 16.0; break;
                    case 2: deducere = 21.0; break;
                    case 3: deducere = 26.0; break;
                    default: deducere = 36.0; break;
                }
            }
            else if (salariu <= salariuMinim + 950)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 10.5; break;
                    case 1: deducere = 15.5; break;
                    case 2: deducere = 20.5; break;
                    case 3: deducere = 25.5; break;
                    default: deducere = 35.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1000)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 10.0; break;
                    case 1: deducere = 15.0; break;
                    case 2: deducere = 20.0; break;
                    case 3: deducere = 25.0; break;
                    default: deducere = 35.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1050)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 9.5; break;
                    case 1: deducere = 14.5; break;
                    case 2: deducere = 19.5; break;
                    case 3: deducere = 24.5; break;
                    default: deducere = 34.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1100)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 9.0; break;
                    case 1: deducere = 14.0; break;
                    case 2: deducere = 19.0; break;
                    case 3: deducere = 24.0; break;
                    default: deducere = 34.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1150)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 8.5; break;
                    case 1: deducere = 13.5; break;
                    case 2: deducere = 18.5; break;
                    case 3: deducere = 23.5; break;
                    default: deducere = 33.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1200)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 8.0; break;
                    case 1: deducere = 13.0; break;
                    case 2: deducere = 18.0; break;
                    case 3: deducere = 23.0; break;
                    default: deducere = 33.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1250)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 7.5; break;
                    case 1: deducere = 12.5; break;
                    case 2: deducere = 17.5; break;
                    case 3: deducere = 22.5; break;
                    default: deducere = 32.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1300)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 7.0; break;
                    case 1: deducere = 12.0; break;
                    case 2: deducere = 17.0; break;
                    case 3: deducere = 22.0; break;
                    default: deducere = 32.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1350)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 6.5; break;
                    case 1: deducere = 11.5; break;
                    case 2: deducere = 16.5; break;
                    case 3: deducere = 21.5; break;
                    default: deducere = 31.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1400)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 6.0; break;
                    case 1: deducere = 11.0; break;
                    case 2: deducere = 16.0; break;
                    case 3: deducere = 21.0; break;
                    default: deducere = 31.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1450)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 5.5; break;
                    case 1: deducere = 10.5; break;
                    case 2: deducere = 15.5; break;
                    case 3: deducere = 20.5; break;
                    default: deducere = 30.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1500)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 5.0; break;
                    case 1: deducere = 10.0; break;
                    case 2: deducere = 15.0; break;
                    case 3: deducere = 20.0; break;
                    default: deducere = 30.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1550)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 4.5; break;
                    case 1: deducere = 9.5; break;
                    case 2: deducere = 14.5; break;
                    case 3: deducere = 19.5; break;
                    default: deducere = 29.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1600)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 4.0; break;
                    case 1: deducere = 9.0; break;
                    case 2: deducere = 14.0; break;
                    case 3: deducere = 19.0; break;
                    default: deducere = 29.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1650)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 3.5; break;
                    case 1: deducere = 8.5; break;
                    case 2: deducere = 13.5; break;
                    case 3: deducere = 18.5; break;
                    default: deducere = 28.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1700)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 3.0; break;
                    case 1: deducere = 8.0; break;
                    case 2: deducere = 13.0; break;
                    case 3: deducere = 18.0; break;
                    default: deducere = 28.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1750)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 2.5; break;
                    case 1: deducere = 7.5; break;
                    case 2: deducere = 12.5; break;
                    case 3: deducere = 17.5; break;
                    default: deducere = 27.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1800)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 2.0; break;
                    case 1: deducere = 7.0; break;
                    case 2: deducere = 12.0; break;
                    case 3: deducere = 17.0; break;
                    default: deducere = 27.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1850)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 1.5; break;
                    case 1: deducere = 6.5; break;
                    case 2: deducere = 11.5; break;
                    case 3: deducere = 16.5; break;
                    default: deducere = 26.5; break;
                }
            }
            else if (salariu <= salariuMinim + 1900)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 1.0; break;
                    case 1: deducere = 6.0; break;
                    case 2: deducere = 11.0; break;
                    case 3: deducere = 16.0; break;
                    default: deducere = 26.0; break;
                }
            }
            else if (salariu <= salariuMinim + 1950)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 0.5; break;
                    case 1: deducere = 5.5; break;
                    case 2: deducere = 10.5; break;
                    case 3: deducere = 15.5; break;
                    default: deducere = 25.5; break;
                }
            }
            else if (salariu <= salariuMinim + 2000)
            {
                switch (numarPersoaneInIntretinere)
                {
                    case 0: deducere = 0; break;
                    case 1: deducere = 5; break;
                    case 2: deducere = 10; break;
                    case 3: deducere = 15; break;
                    default: deducere = 25; break;
                }
            }
            else
            {// Pentru salarii mai mari de salariul minim + 2000
                deducere = 0;
            }

            return deducere;
        }

        

        private void dateangjbtn_Click(object sender, EventArgs e)
        {
            DateAngajatForm dateAngajatForm = new DateAngajatForm(this);
            dateAngajatForm.Show();
        }

    }
}
