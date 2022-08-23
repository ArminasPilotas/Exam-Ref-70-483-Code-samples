using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_80_483
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        public string Description { get; set; }

        public CustomAttribute(string description)
        {
            Description = description;
        }
    }

    [CustomAttribute("Isolated")]
    public class Random
    {

    }
}
