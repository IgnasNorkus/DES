using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            encryptedTexttb.Text = EncryptECB(eTexttb.Text, eKeytb.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decryptedTexttb.Text = DecryptECB(dTexttb.Text, dKeytb.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        public string EncryptECB(string source, string key)
        {
            try
            {
                TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

                byte[] byteHash;
                byte[] byteBuff;

                byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                desCryptoProvider.Key = byteHash;
                desCryptoProvider.Mode = CipherMode.ECB;
                byteBuff = Encoding.UTF8.GetBytes(source);

                string encoded =
                    Convert.ToBase64String(desCryptoProvider.CreateEncryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                return encoded;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static string DecryptECB(string encodedText, string key)
        {
            try
            {
                TripleDESCryptoServiceProvider desCryptoProvider = new TripleDESCryptoServiceProvider();
                MD5CryptoServiceProvider hashMD5Provider = new MD5CryptoServiceProvider();

                byte[] byteHash;
                byte[] byteBuff;

                byteHash = hashMD5Provider.ComputeHash(Encoding.UTF8.GetBytes(key));
                desCryptoProvider.Key = byteHash;
                desCryptoProvider.Mode = CipherMode.ECB;
                byteBuff = Convert.FromBase64String(encodedText);

                string plaintext = Encoding.UTF8.GetString(desCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));
                return plaintext;
            }
            catch (System.Security.Cryptography.CryptographicException)
            {

                throw;
            }

        }

    }
}
