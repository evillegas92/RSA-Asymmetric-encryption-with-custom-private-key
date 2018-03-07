using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using RSAEncryptionDecryptionCustomKeys;

namespace WindowsForms
{
	public partial class Form1 : Form
	{
		private RSACryptoServiceProvider rsa;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				string filePath = tbxFilePath.Text;
				string privatePemText = tbxPrivatePemText.Text;

				byte[] encryptedData = Encrypt(filePath, privatePemText);

				MessageBox.Show(this, "Encryption successful! Press OK to continue...", "Success");

				string decryptedFilePath = tbxDecryptedFilePath.Text;
				Decrypt(encryptedData, decryptedFilePath);

				MessageBox.Show(this, "Decryption successful!", "Success");
			}
			catch (Exception exception)
			{
				MessageBox.Show(this, exception.Message, "Error");
			}
		}

		private byte[] Encrypt(string filePath, string privatePemText)
		{
			this.rsa = Encryption.CreateRSACryptoServiceProvider(privatePemText);
			byte[] dataToEnCrypt = FileManager.ReadFileContent(filePath);
			return rsa.Encrypt(dataToEnCrypt, true);
		}

		private void Decrypt(byte[] encryptedData, string decryptedFilePath)
		{
			byte[] decryptedData = this.rsa.Decrypt(encryptedData, true);
			FileManager.WriteFileContent(decryptedData, decryptedFilePath);
		}
	}
}
