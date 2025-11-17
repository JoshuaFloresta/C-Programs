using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingTextFile
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        public static string SetFileName;

        private void btnCreate_Click(object sender, EventArgs e)

        {
            using (FrmFileName nameForm = new FrmFileName())
            {
                DialogResult dr = nameForm.ShowDialog();

                if (dr != DialogResult.OK)
                {
                    MessageBox.Show("File creation cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            string getInput = txtInput.Text ?? string.Empty;

            try
            {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = FrmFileName.SetFileName;

                if (string.IsNullOrWhiteSpace(fileName))
                {
                    MessageBox.Show("Filename was not provided. File not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string fullPath = Path.Combine(docPath, fileName);

                using (StreamWriter outputFile = new StreamWriter(fullPath))
                {
                    outputFile.WriteLine(getInput);
                }

                MessageBox.Show($"File created:\n{fullPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine(getInput);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while creating the file:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        }
    }
