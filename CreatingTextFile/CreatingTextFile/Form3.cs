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
using System.Xml.Linq;

namespace CreatingTextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();

            cboGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
            cboProgram.Items.AddRange(new string[] { "BS Information Technology", "BS Computer Science", "BS Computer Engineering ", "BS Tourism" });
            txtMI.Items.AddRange(
                Enumerable.Range('A', 26)
              .Select(x => ((char)x).ToString())
              .ToArray()
            );

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string sn = txtStudentNo.Text.Trim();
            if (string.IsNullOrWhiteSpace(sn))
            {
                MessageBox.Show("Student Number is required!");
                return;
            }


            foreach (char c in Path.GetInvalidFileNameChars())
                sn = sn.Replace(c.ToString(), "");


            string fileName = txtLastName.Text.Trim() + '_' + txtFirstName.Text.Trim() + ".txt";
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, fileName);


            string[] info =
              {
               "Student No.: " + txtStudentNo.Text,
               "Program: " + cboProgram.Text,
               "Last Name: " + txtLastName.Text,
               "First Name: " + txtFirstName.Text,
               "M.I.: " + txtMI.Text,
               "Age: " + txtAge.Text,
               "Gender: " + cboGender.Text,
               "Birthday: " + dtBirthday.Value.ToLongDateString(),
               "Contact No.: " + txtContactNo.Text
        };


            try
            {
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    foreach (var line in info)
                        writer.WriteLine(line);
                }

                MessageBox.Show($"Registration Sucess! {fileName} at:{fullPath} ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}