using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SALARII
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void loginlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Creează o instanță a formularului LoginForm
            LoginForm loginForm = new LoginForm();
            // Afișează formularul LoginForm
            loginForm.Show();
            // Închide formularul SignUpForm (opțional, dacă dorești să-l închizi)
            this.Close();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            string nume = numetxt.Text;
            string prenume = prenumetxt.Text;
            string utiliz = utiliztxt.Text;
            string parola = parolatxt.Text;
            string confparola = confpasstxt.Text;

            if (!IsValidName(nume) || !IsValidName(prenume))
            {
                MessageBox.Show("Numele și prenumele trebuie să înceapă cu literă mare și să conțină doar litere.");
                return;
            }

            if (!IsValidEmail(utiliz))
            {
                MessageBox.Show("Adresă de email invalidă.");
                return;
            }

            if (!IsValidPassword(parola))
            {
                MessageBox.Show("Parola trebuie să conțină cel puțin o literă mare, o cifră, un caracter special și să aibă 8 caractere.");
                return;
            }

            if (parola != confparola)
            {
                MessageBox.Show("Parola și confirmarea parolei nu corespund.");
                return;
            }

            // Save information to file
            SaveToFile(utiliz, parola);

            MessageBox.Show("Cont creat cu succes!");
            // Optionally, you might want to close the form after successful signup
            this.Close();
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[A-Z][a-zA-Z]*$");
        }

        private bool IsValidEmail(string email)
        {
            // Definirea expresiei regulate pentru validarea adresei de e-mail
            string regex = @"^[a-zA-Z0-9_+&-]+(?:\.[a-zA-Z0-9_+&-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,7}$";

            // Folosirea clasei Regex pentru validare
            return Regex.IsMatch(email, regex);
        }

        //try
        //{
        //    var addr = new System.Net.Mail.MailAddress(email);
        //    return addr.Address == email;
        //}
        //catch
        //{
        //    return false;
        //}


        private bool IsValidPassword(string password)
        {
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Z]") &&
                   Regex.IsMatch(password, @"\d") &&
                   Regex.IsMatch(password, @"[\W_]");
        }

        private void SaveToFile(string email, string password)
        {
            string fileName = $"parola_{email}.txt";
            File.WriteAllText(fileName, password);
        }

        private void numetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
