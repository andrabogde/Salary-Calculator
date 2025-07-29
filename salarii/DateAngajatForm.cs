using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SALARII
{
    public partial class DateAngajatForm : Form
    {
        private Form1 form1;

        public DateAngajatForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void DateAngajatForm_Load(object sender, EventArgs e)
        {
            ;
            dsfarsittxt.ReadOnly = true;

            // Dezactivează controalele dacă nu este selectat nimic în cocmb
            ToggleControls(false);
        }

        private void datainceputacttxt_TextChanged(object sender, EventArgs e)
        {
            // Poți adăuga logică suplimentară aici, dacă este necesar
        }




        private void dsfarsittxt_TextChanged(object sender, EventArgs e)
        {
            // Poți adăuga logică suplimentară aici, dacă este necesar
        }

        private void weekcbx_CheckedChanged(object sender, EventArgs e)
        {
            // Poți adăuga logică suplimentară aici, dacă este necesar
        }

        private void supltxt_TextChanged(object sender, EventArgs e)
        {
            // Verifică dacă valorile sunt disponibile
            double zileLucrate = form1.ZileLucrate;
            double orePeZi = form1.OrePeZi;
            double salariu = form1.Salariu;
            double oreLucrateTotal = form1.OreLucrate;

            // Calculează valoarea lui x
            double x = zileLucrate * orePeZi;
            double bani = salariu / x;

            // Verifică dacă s-au depășit orele lucrate standard
            if (oreLucrateTotal > x)
            {
                // Calculează orele suplimentare
                double oreSuplimentare = oreLucrateTotal - x;

                // Calculează suma pentru orele suplimentare
                int s = (int)(oreSuplimentare * bani * 1.75); // Coeficientul de 1,75 pentru ore suplimentare

                // Completează supltxt cu orele suplimentare și suma calculată

            }

        }


        private void noaptetxt_TextChanged(object sender, EventArgs e)
        {

        }



        private void anlbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToggleControls(bool enable)
        {
            monthCalendar2.Enabled = enable;
            sal1txt.Enabled = enable;
            sal2txt.Enabled = enable;
            sal3txt.Enabled = enable;
            sal4txt.Enabled = enable;
            sal5txt.Enabled = enable;
            sal6txt.Enabled = enable;
            nrzile6txt.Enabled = enable;

        }

        private void salbtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(noaptetxt.Text, out int oreNoapte))
            {
                double zileLucrate = form1.ZileLucrate;
                double orePeZi = form1.OrePeZi;
                double salariu = form1.Salariu;
                double plataPerOra = salariu / (zileLucrate * orePeZi);
                double zileRamase = zileLucrate - numarZileConcediu;
                double sal = zileRamase * plataPerOra * orePeZi;

                // Calculăm totalul pentru selecțiile din CheckedListBox
                double totalRetineri = 0.0;
                double totalSporuri = 0.0;
                foreach (int index in retinerichklst.CheckedIndices)
                {
                    switch (index)
                    {
                        case 0:
                            totalRetineri += salariu * 0.01;
                            break;
                        case 1:
                            totalRetineri += salariu * 0.05;
                            break;
                        case 2:
                            totalRetineri += salariu * 0.02;
                            break;
                        case 3:
                            totalRetineri += salariu * 0.05;
                            break;
                    }
                }
                foreach (int index in caracperchklist.CheckedIndices)
                {
                    switch (index)
                    {
                        case 0:
                            totalSporuri += salariu * 0.05;
                            break;
                        case 1:
                            totalSporuri += salariu * 0.05;
                            break;
                        case 2:
                            totalSporuri += salariu * 0.1;
                            break;
                       
                    }
                }
                double x = calculConcediu();
                // Calculăm salariul rezultat după aplicarea reținerilor și concediului
                double salariuRezultat =( sal + calculConcediu()  + totalSporuri) - totalRetineri ;
                form1.SalRezTxt = salariuRezultat.ToString("F2");

                // Convertim string-ul din SalRezTxt într-un double
                if (double.TryParse(form1.SalRezTxt, out double salariuFinal))
                {
                    if (int.TryParse(sportxt.Text, out int spor))
                    {
                        // Aplicăm sporul la salariul final
                        salariuFinal += salariuFinal * spor / 100;
                    }

                    // Calculăm suma pentru orele de noapte
                    double sumaOreNoapte = oreNoapte * plataPerOra * 0.25;
                    salariuFinal += sumaOreNoapte;

                    // Setăm noua valoare calculată
                    form1.SalRezTxt = salariuFinal.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Valoarea din SalRezTxt nu este validă.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Introduceți un număr valid pentru orele de noapte.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        public double calculConcediu()
        {
            bool isSelected = cocmb.SelectedItem != null;
            double zileLucrate = form1.ZileLucrate;
            double orePeZi = form1.OrePeZi;
            double salariu = form1.Salariu;
            double plataPerOra = salariu / (zileLucrate * orePeZi);
            double zileRamase = zileLucrate - numarZileConcediu;
            double sal = zileRamase * plataPerOra;
            // Activează sau dezactivează controalele în funcție de selecție
            ToggleControls(isSelected);

            if (isSelected)
            {
                string selectedItem = cocmb.SelectedItem.ToString();

                // Actualizează numărul de zile selectate din calendar înainte de a apela metodele de calcul
                DateTime startDate = monthCalendar2.SelectionStart;
                DateTime endDate = monthCalendar2.SelectionEnd;
                TimeSpan interval = endDate - startDate;
                numarZileConcediu = interval.Days + 1; // Actualizează numărul de zile selectate din calendar
                if (selectedItem == "Concediu medical")
                {
                    MessageBox.Show("Ați selectat Concediu Medical.");
                    // Apelează metoda de calcul pentru concediu medical
                    sal = calculConcediuMedical();
                }
                else if (selectedItem == "Concediu de odihna")
                {
                    MessageBox.Show("Ați selectat Concediu de Odihnă.");
                    // Apelează metoda de calcul pentru concediu de odihnă
                    sal = calculConcediuOdihna();
                }
            }
            else
            {
                sal = 0;
            }


            return sal;

        }


        private int numarZileConcediu = 0;

        private void cocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifică dacă a fost selectată o opțiune în cocmb
            bool isSelected = cocmb.SelectedItem != null;

            // Activează sau dezactivează controalele în funcție de selecție
            ToggleControls(isSelected);

            if (isSelected)
            {
                string selectedItem = cocmb.SelectedItem.ToString();

                // Actualizează numărul de zile selectate din calendar înainte de a apela metodele de calcul
                DateTime startDate = monthCalendar2.SelectionStart;
                DateTime endDate = monthCalendar2.SelectionEnd;
                TimeSpan interval = endDate - startDate;
                numarZileConcediu = interval.Days + 1; // Actualizează numărul de zile selectate din calendar

                if (selectedItem == "Concediu medical")
                {
                    MessageBox.Show("Ați selectat Concediu Medical.");
                    // Apelează metoda de calcul pentru concediu medical
                    calculConcediuMedical();
                }
                else if (selectedItem == "Concediu de odihna")
                {
                    MessageBox.Show("Ați selectat Concediu de Odihnă.");
                    // Apelează metoda de calcul pentru concediu de odihnă
                    calculConcediuOdihna();
                }
            }
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Obține data de început și de sfârșit din selecția calendarului
            DateTime startDate = monthCalendar2.SelectionStart;
            DateTime endDate = monthCalendar2.SelectionEnd;

            // Verifică dacă data de sfârșit este înainte de data de început
            if (endDate < startDate)
            {
                MessageBox.Show("Data de sfârșit nu poate fi înainte de data de început.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculează numărul de zile dintre startDate și endDate
            TimeSpan interval = endDate - startDate;
            numarZileConcediu = interval.Days + 1; // Include și ziua de început

            // Completează TextBox-ul cu intervalul de date și numărul de zile
            string rezultat = $"Interval: {startDate:dd.MM.yyyy} - {endDate:dd.MM.yyyy} ({numarZileConcediu} zile)";
            dsfarsittxt.Text = rezultat;
        }


        private double calculConcediuOdihna()
        {
            // Parsează salariile din ultimele 6 luni
            double.TryParse(sal1txt.Text, out double sal1);
            double.TryParse(sal2txt.Text, out double sal2);
            double.TryParse(sal3txt.Text, out double sal3);
            double.TryParse(sal4txt.Text, out double sal4);
            double.TryParse(sal5txt.Text, out double sal5);
            double.TryParse(sal6txt.Text, out double sal6);

            // Verifică dacă numărul de zile lucrate pe ultimele 6 luni este valid
            if (!double.TryParse(nrzile6txt.Text, out double nrzile) || nrzile == 0)
            {
                MessageBox.Show("Te rog introdu un număr valid de zile lucratoare în ultimele 6 luni.");

            }

            // Calculează media salariilor pe ultimele 6 luni
            double salariuMediu = (sal1 + sal2 + sal3 + sal4 + sal5 + sal6) / nrzile;

            // Calculează suma pentru concediu de odihnă (salariu mediu * numărul de zile selectat)
            double valoareConcediuOdihna = salariuMediu * numarZileConcediu;

            return valoareConcediuOdihna;

            // Afișează rezultatul în saltxt
            //saltxt.Text = valoareConcediuOdihna.ToString("F2");
        }

        // Metoda pentru calculul concediului medical
        private double calculConcediuMedical()
        {
            // Parsează salariile din ultimele 6 luni
            double.TryParse(sal1txt.Text, out double sal1);
            double.TryParse(sal2txt.Text, out double sal2);
            double.TryParse(sal3txt.Text, out double sal3);
            double.TryParse(sal4txt.Text, out double sal4);
            double.TryParse(sal5txt.Text, out double sal5);
            double.TryParse(sal6txt.Text, out double sal6);

            // Verifică dacă numărul de zile lucrate pe ultimele 6 luni este valid
            if (!double.TryParse(nrzile6txt.Text, out double nrzile) || nrzile == 0)
            {
                MessageBox.Show("Te rog introdu un număr valid de zile lucratoare în ultimele 6 luni.");

            }

            // Calculează media salariilor pe ultimele 6 luni
            double salariuMediu = (sal1 + sal2 + sal3 + sal4 + sal5 + sal6) / nrzile;

            // Calculează suma pentru concediu medical (salariu mediu * nr zile * 0.75)
            double valoareConcediuMedical = salariuMediu * numarZileConcediu * 0.75;
            return valoareConcediuMedical;
            // Afișează rezultatul
            //  saltxt.Text = valoareConcediuMedical.ToString("F2");
        }

        private void sportxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void sal1txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }
        private void sal2txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }

        private void sal3txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }

        private void sal4txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }

        private void sal5txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }

        private void sal6txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }

        private void nrzile6txt_TextChanged(object sender, EventArgs e)
        {
            calculConcediuOdihna();
        }





        private void thichetetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void retinerichklst_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Verificăm dacă elementul este bifat
            if (e.NewValue == CheckState.Checked)
            {
                string mesaj = string.Empty;
                double x;
                // Verificăm care element a fost bifat și generăm mesajul corespunzător
                switch (e.Index)
                {
                    case 0:
                        mesaj = "Ați ales Poprire";
                        x = 0.01;
                        break;
                    case 1:
                        mesaj = "Ați ales Salariu în avans";
                        x = 0.05;
                        break;
                    case 2:
                        mesaj = "Ați ales Întârziere";
                        x = 0.02;
                        break;
                    case 3:
                        mesaj = "Ați ales Concediu în avans";
                        x = 0.05;
                        break;
                    default:
                        break;
                }

                // Afișăm mesajul într-o fereastră de tip MessageBox
                if (!string.IsNullOrEmpty(mesaj))
                {
                    MessageBox.Show(mesaj, "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void caracperchklist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Verificăm dacă elementul este bifat
            if (e.NewValue == CheckState.Checked)
            {
                string mesaj = string.Empty;
                double x;
                // Verificăm care element a fost bifat și generăm mesajul corespunzător
                switch (e.Index)
                {
                    case 0:
                        mesaj = "Ați ales VECHIME";
                        x = 0.05;
                        break;
                    case 1:
                        mesaj = "Ați ales  CONDITII GRELE";
                        x = 0.05;
                        break;
                    case 2:
                        mesaj = "Ați ales CONDITII PERICULOASE";
                        x = 0.1;
                        break;

                    default:
                        break;
                }

                // Afișăm mesajul într-o fereastră de tip MessageBox
                if (!string.IsNullOrEmpty(mesaj))
                {
                    MessageBox.Show(mesaj, "Informație", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}