using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Auth.GG_Winform_Example
{
	// Token: 0x0200001E RID: 30
	internal class Encryption
	{
		// Token: 0x060000BC RID: 188 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		public static string APIService(string value)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.EncryptString(value, key, bytes);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000D218 File Offset: 0x0000B418
		public static string EncryptService(string value)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			string str = Encryption.EncryptString(value, key, bytes);
			int length = int.Parse(OnProgramStart.AID.Substring(0, 2));
			return str + Security.Obfuscate(length);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000D294 File Offset: 0x0000B494
		public static string DecryptService(string value)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTKEY));
			byte[] key = SHA256.Create().ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Constants.APIENCRYPTSALT)));
			return Encryption.DecryptString(value, key, bytes);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
		public static string EncryptString(string plainText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.ASCII.GetBytes(plainText);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array, 0, array.Length);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000D370 File Offset: 0x0000B570
		public static string DecryptString(string cipherText, byte[] key, byte[] iv)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = key;
			aes.IV = iv;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(cipherText);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array2 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array2, 0, array2.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000D40C File Offset: 0x0000B60C
		public static string Decode(string text)
		{
			text = text.Replace('_', '/').Replace('-', '+');
			int num = text.Length % 4;
			if (num != 2)
			{
				if (num == 3)
				{
					text += "=";
				}
			}
			else
			{
				text += "==";
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(text));
		}
	}
}
