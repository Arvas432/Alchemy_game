using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    public class SUPERLOOOOG : IDisposable
    {
        public String LogFilePath = "";
        private StreamWriter SWRiter;
        public SUPERLOOOOG(String FPath, bool Append = true)
        {
            LogFilePath = FPath;
            SWRiter = new StreamWriter(FPath, Append, Encoding.UTF8);
            SWRiter.WriteLine("=================================================================");
            SWRiter.WriteLine($"APPSTART {DateTime.Now}");
            SWRiter.WriteLine("=================================================================");
        }
        public void WriteLine(String str)
        {
            SWRiter.WriteLine(str);
        }
        public void Dispose()
        {
            SWRiter.Flush();
            SWRiter.Close();
            SWRiter.Dispose();
        }
    }
}
