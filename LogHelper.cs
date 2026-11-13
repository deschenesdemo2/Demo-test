using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeracodeDemo
{
  internal class LogHelper
  {
    public void WriteToFile(string fileName)
    {
      string path = "/var/app/files/" + fileName;

      File.ReadAllText(path);
    }
  }
}