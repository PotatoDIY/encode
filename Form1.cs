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

namespace Encode
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsa;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("PublicKey.xml"))
            {
                using (StreamReader streamReader = new StreamReader("PublicKey.xml")) // 读取运行目录下的PublicKey.xml
                {
                    rsa = new RSACryptoServiceProvider();
                    rsa.FromXmlString(streamReader.ReadToEnd()); // 将公匙载入进RSA实例中
                }
            }
            else
            {
                MessageBox.Show("软件根目录缺少公钥文件：PublicKey.xml");
                Application.Exit();
            }
        }

        private string RSAEncrypt(string content)
        {
            string encryptedContent = string.Empty;
            byte[] encryptedData = rsa.Encrypt(Encoding.Default.GetBytes(content), false);
            encryptedContent = Convert.ToBase64String(encryptedData);
            return encryptedContent;
        }

        private void buttonEn_Click(object sender, EventArgs e)
        {
            textBoxEnString.Text = RSAEncrypt(textBoxString.Text);
        }
    }
}
