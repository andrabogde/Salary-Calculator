using System;
using System.IO; // Needed for file operations
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SALARII
{
    public partial class ForgotPassForm : Form
    {
        public ForgotPassForm()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            // Definirea expresiei regulate pentru validarea adresei de e-mail
            string regex = @"^[a-zA-Z0-9_+&-]+(?:\.[a-zA-Z0-9_+&-]+)*@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,7}$";

            // Folosirea clasei Regex pentru validare
            return Regex.IsMatch(email, regex);
        }

        private bool IsValidPassword(string password)
        {
            // Validate that the password has at least 8 characters, one uppercase letter, one digit, and one special character
            return password.Length >= 8 &&
                   Regex.IsMatch(password, @"[A-Z]") && // At least one uppercase letter
                   Regex.IsMatch(password, @"\d") &&   // At least one digit
                   Regex.IsMatch(password, @"[\W_]");  // At least one special character
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailtxt.Text;
            string newPassword = parolatxt.Text;

            // Validate the email
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Adresă de email invalidă.");
                return;
            }

            // Validate the new password using IsValidPassword
            if (!IsValidPassword(newPassword))
            {
                MessageBox.Show("Parola trebuie să aibă cel puțin 8 caractere, o literă mare, o cifră și un caracter special.");
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

            try
            {
                // Update the file with the new password
                File.WriteAllText(fileName, newPassword);

                // Display success message
                MessageBox.Show("Parola a fost actualizată cu succes!");
            }
            catch (Exception ex)
            {
                // Handle any potential errors that may occur during file operations
                MessageBox.Show($"Eroare la actualizarea parolei: {ex.Message}");
            }
        }

        private void emailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void parolatxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
