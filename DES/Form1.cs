using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DES
{
    public partial class Form1 : Form
    {

        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";
        static readonly string fileNameOriginal = "Encryption.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filecb1.Checked == true)
            {
                string[] lines = File.ReadAllLines(fileNameOriginal);
                eTexttb.Text = lines[0];
                eKeytb.Text = lines[1];
                encryptedTexttb.Text = EncryptECB(eTexttb.Text, eKeytb.Text);
                lines[2] = encryptedTexttb.Text;
                File.WriteAllLines(fileNameOriginal, lines);
            }
            else
            {
            encryptedTexttb.Text = EncryptECB(eTexttb.Text, eKeytb.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filecb1.Checked == true)
            {
                string[] lines = File.ReadAllLines(fileNameOriginal);
                dTexttb.Text = lines[2];
                dKeytb.Text = lines[1];
                decryptedTexttb.Text = DecryptECB(dTexttb.Text, dKeytb.Text);
                lines[2] = decryptedTexttb.Text;
                File.WriteAllLines(fileNameOriginal, lines);
            }
            else
            {
            decryptedTexttb.Text = DecryptECB(dTexttb.Text, dKeytb.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (filecb1.Checked == true)
            {
                string[] lines = File.ReadAllLines(fileNameOriginal);
                eTexttb.Text = lines[0];
                eKeytb.Text = lines[1];
                encryptedTexttb.Text = EncryptCBC(eTexttb.Text, eKeytb.Text);
                lines[2] = encryptedTexttb.Text;
                File.WriteAllLines(fileNameOriginal, lines);
            }
            else
            {
                encryptedTexttb.Text = EncryptCBC(eTexttb.Text, eKeytb.Text);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (filecb1.Checked == true)
            {
                string[] lines = File.ReadAllLines(fileNameOriginal);
                dTexttb.Text = lines[2];
                dKeytb.Text = lines[1];
                decryptedTexttb.Text = DecryptCBC(dTexttb.Text, dKeytb.Text);
                lines[2] = decryptedTexttb.Text;
                File.WriteAllLines(fileNameOriginal, lines);
            }
            else
            {
                decryptedTexttb.Text = DecryptCBC(dTexttb.Text, dKeytb.Text);
            }
            
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

        public static string EncryptCBC(string source, string key)
        {
            try
            {
                byte[] plainTextBytes = Encoding.UTF8.GetBytes(source);

                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(key)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
                var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

                byte[] cipherTextBytes;

                using (var memoryStream = new MemoryStream())
                {
                    using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        cipherTextBytes = memoryStream.ToArray();
                        cryptoStream.Close();
                    }
                    memoryStream.Close();
                }
                return Convert.ToBase64String(cipherTextBytes);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Key is not at least eight bytes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        public static string DecryptCBC(string source, string key)
        {
            try
            {
                byte[] cipherTextBytes = Convert.FromBase64String(source);
                byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(key)).GetBytes(256 / 8);
                var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

                var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
                var memoryStream = new MemoryStream(cipherTextBytes);
                var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());

            }
            catch (System.ArgumentException)
            {

                MessageBox.Show("Key is not at least eight bytes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

    }
}
