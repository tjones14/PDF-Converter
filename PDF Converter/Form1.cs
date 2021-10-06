using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using convert = PDF_Converter.Utilities.Converters;

namespace PDF_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            var file = @"C:\Users\tazar\Desktop\Paste\20130922_141238.jpg";

            // test for file type 


            // if document is an image file
            convert.ImageConverter(file);
        }
    }
}
