using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_CaserCipher
{
    public partial class Caser : Form
    {
        public Caser()
        {
            InitializeComponent();
            CenterToScreen();
            rad_Encrypt.Checked = true;
        }
        private char EncryptChar(char ch, int k)
        {
            if (Char.IsLetter(ch))
            {
                return (char)('A' + (ch - 'A' + k) % 26);
            }
            else
            {
                return ch;
            }
        }
        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
