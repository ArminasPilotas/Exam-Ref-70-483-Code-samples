using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_80_483
{
    public interface IControl
    {
        void Paint();
    }

    public interface ISurface
    {
        void Paint();
    }
    public class SampleClass : IControl, ISurface
    {
        void IControl.Paint()
        {
            Console.WriteLine("IControl paint");
        }

        void ISurface.Paint()
        {
            Console.WriteLine("ISurface paint");
        }
    }

    /*
    SampleClass sample = new SampleClass();
    IControl control = sample;
    ISurface surface = sample;

    // The following lines all call the same method.
    //sample.Paint(); // Compiler error.
    control.Paint();  // Calls IControl.Paint on SampleClass.
    surface.Paint();  // Calls ISurface.Paint on SampleClass.     
    */
}
