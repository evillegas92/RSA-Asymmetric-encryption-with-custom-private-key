using System;
using System.IO;
using System.Text;

namespace RSAEncryptionDecryptionCustomKeys
{
	public static class FileManager
	{
		public static byte[] ReadFileContent(string pathToFile)
		{
			UTF8Encoding utf8encoding = new UTF8Encoding();
			string textContent =  File.ReadAllText(pathToFile);
			byte[] contentBytes = utf8encoding.GetBytes(textContent);
			return contentBytes;
		}

		public static void WriteFileContent(byte[] fileContent, string pathToFile)
		{
			string utf8EncodedContent = Encoding.UTF8.GetString(fileContent);
			File.WriteAllText(pathToFile, utf8EncodedContent);
		}
	}
}