using System.IO;
using System.Security.Cryptography;
using OpenSSL.PrivateKeyDecoder;

namespace RSAEncryptionDecryptionCustomKeys
{
	public class Encryption
	{
		private Encryption() { }

		/// <summary>
		/// Creates an RSACryptoServiceProvider with the custom private key specified by privateKeyFilePath parameter.
		/// To generate RSA private.key and public.crt key-pair files, use OpenSSL command:
		/// openssl req -x509 -sha256 -nodes -days 365 -newkey rsa:2048 -keyout private.key -out certificate_pub.crt
		/// Source: https://github.com/StefH/OpenSSL-X509Certificate2-Provider
		/// Nuget package necessary: https://www.nuget.org/packages/OpenSSL.X509Certificate2.Provider
		/// </summary>
		/// <param name="privateKeyFilePath">Path to the .key file containing the RSA private key.</param>
		/// <returns></returns>
		public static RSACryptoServiceProvider CreateRSACryptoServiceProvider(string privateKeyFilePath)
		{
			string privateKeyText = File.ReadAllText(privateKeyFilePath);

			IOpenSSLPrivateKeyDecoder decoder = new OpenSSLPrivateKeyDecoder();
			RSACryptoServiceProvider rsaProvider = decoder.Decode(privateKeyText);

			return rsaProvider;
		}
	}
}