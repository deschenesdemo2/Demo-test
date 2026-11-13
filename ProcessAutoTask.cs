using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeracodeDemo
{
  public class ProcessAutoTask
  {
    public void CheckPing(string host)
    {
      var process = new Process();

      process.StartInfo.FileName = "ping";
      process.StartInfo.Arguments = host;
      process.StartInfo.UseShellExecute = false;

      process.Start();
    }
  }
}
