using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        backend gc = new backend();

        int type = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GenPassButton_Click(object sender, EventArgs e)
        {
            if (IncludeSymCBox.Checked && IncludeNumsCBox.Checked) { type = 0; }
            else if (!IncludeSymCBox.Checked && IncludeNumsCBox.Checked) { type = 1; }
            else if (IncludeSymCBox.Checked && !IncludeNumsCBox.Checked) { type = 2; }
            else if (!IncludeSymCBox.Checked && !IncludeNumsCBox.Checked) { type = 3; }

            PassOutputTBox.Text = gc.GeneratePassword(type, Convert.ToInt32(PassLengthBox.Value));
        }
    }
}
