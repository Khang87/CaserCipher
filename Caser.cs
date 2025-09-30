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

        private void rad_Encrypt_CheckedChanged(object sender, EventArgs e)
        {
            btn_EncryptMessage.Text = "Encrypt Message";
        }

        private void rad_Decrypt_CheckedChanged(object sender, EventArgs e)
        {
            btn_EncryptMessage.Text = "Decrypt Message";
        }
        private void encryptMessage(string msg,int k)
        {
           string result = "";
            txt_Result.Text = "";
            int len = msg.Length;
            for(int i=0;i<len;i++)
            {
                result += EncryptChar(msg[i], k);
            }
            txt_Result.Text = result;
        }
        private void btn_EncryptMessage_Click(object sender, EventArgs e)
        {
            string msg = txt_Message.Text;
            if (msg == "")
            {
                MessageBox.Show("Vui long nhap thong diep can ma hoa !");
                return;
            }
            msg = msg.ToUpper();
            int k = (int)NumUpDown_Key.Value;
            if (rad_Encrypt.Checked)
            {

            }
            else
            {
                k = 26 - k;
            }
            encryptMessage(msg, k);
        }
    }
}
