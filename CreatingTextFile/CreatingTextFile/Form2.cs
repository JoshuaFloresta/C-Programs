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
    public partial class FrmFileName : Form
    {
        public FrmFileName()
        {
            InitializeComponent();
        }

        public static string SetFileName;

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string name = txtFileName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter a valid filename!");
                return;
            }


            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c.ToString(), "");


            SetFileName = name + ".txt";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
