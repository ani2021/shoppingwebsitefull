using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Oasis.Configurations;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Oasis.Models;

namespace Oasis.Services
{
	public class SecurityService
	{
		public static byte[] GenerateSalt()
		{
			byte[] salt = new byte[256 / 8];
			using(var rng = RandomNumberGenerator.Create())
			{
				rng.GetBytes(salt);
			}
			return salt;
		}

		public static string ToHex(byte[] r)
		{
			string hexString = BitConverter.ToString(r);
			return hexString.Replace("-", "");
		}

		public static byte[] GetSalt(string hex)
		{
			int chars = hex.Length;
			byte[] ba = new byte[chars / 2];
			for(int i = 0; i < chars; i += 2)
			{
				ba[i/2] = Convert.ToByte(hex.Substring(i, 2), 16);
			}
			return ba;
		}

		public static string GenerateHash(string un, string str, byte[] salt)
		{
			return Convert.ToBase64String(KeyDerivation.Pbkdf2(password: un+str,	salt: salt,	prf: KeyDerivationPrf.HMACSHA1,	iterationCount: 10000, numBytesRequested: 256 / 8));
		}
	}
}