using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeracodeDemo
{
  public class LogHelper
  {
    public string WriteToFile(string fileName)
    {
      string path = "/var/app/files/" + fileName;

      return File.ReadAllText(path);
    }
  }
}
