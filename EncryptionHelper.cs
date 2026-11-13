using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VeracodeDemo
{
  public class EncryptionHelper
  {
    public string GenerateToken(string clientId)
    {
      using var md5 = MD5.Create();

      byte[] input = Encoding.UTF8.GetBytes(clientId);
      byte[] hash = md5.ComputeHash(input);

      return Convert.ToHexString(hash);
    }
  }
}
