    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace SALARII
    {
        public partial class SaveFileForm : Form
        {
            public string FileName { get; private set; }

            public SaveFileForm()
            {
                InitializeComponent();
            }

            private void okButton_Click(object sender, EventArgs e)
            {
                string fileName = fileNameTextBox.Text;
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), fileName + ".txt");

                if (File.Exists(fullPath))
                {
                    MessageBox.Show("Numele fișierului este deja folosit!\nVă rugăm alegeți altul!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FileName = fullPath;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            private void cancelButton_Click(object sender, EventArgs e)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

    }

