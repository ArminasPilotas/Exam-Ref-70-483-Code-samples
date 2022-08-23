using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_80_483
{
    public class ForcedGarbageCollector
    {
        public void ReadToFile(string fileName, string text)
        {
            StreamWriter stream = File.CreateText(fileName);

            stream.WriteLine(text);

            GC.Collect();
            GC.WaitForPendingFinalizers();

            File.Delete(fileName);
        }
    }
}
