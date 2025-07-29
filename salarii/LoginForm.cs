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

namespace SALARII
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Evenimentul LinkClicked pentru LinkLabel
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Creează o instanță a formularului SignUp
            SignUpForm signUpForm = new SignUpForm();
            // Afișează formularul SignUp
            signUpForm.Show();
            // Opțional: Poți ascunde formularul Login pentru a nu-l mai afișa
            this.Hide();
        }

        private void forgotpasslink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassForm forgotPassForm = new ForgotPassForm();
            // Afișează formularul SignUp
            forgotPassForm.Show();
            // Opțional: Poți ascunde formularul Login pentru a nu-l mai afișa
            this.Hide();
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Get the input values
            string email = utilizatortxt.Text;
            string password = parolatxt.Text;

            // Validate the email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Adresă de email invalidă.");
                return;
            }

            // Define the file name based on the email
            string fileName = $"parola_{email}.txt";

            // Check if the file exists in the current directory
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Cont inexistent.");
                return;
            }

            // Read the stored password from the file
            string storedPassword = File.ReadAllText(fileName).Trim();

            // Check if the entered password matches the stored password
            if (password == storedPassword)
            {
                // If the password is correct, show Form1
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                // If the password doesn't match, show an error message
                MessageBox.Show("Parola incorectă.");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Definirea expresiei regulate pentru validarea adresei de e-mail
            string regex = @"^[a-zA-Z0-9_+&-]+(?:\.[a-zA-Z0-9_+&-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,7}$";

            // Folosirea clasei Regex pentru validare
            return Regex.IsMatch(email, regex);
        }


        private void utilizatortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void parolatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
