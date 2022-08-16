using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageProgramFlow.Events_and_Callbacks
{
    public class CustomEventArgument : EventArgs
    {
        public CustomEventArgument(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }

    public class Pub
    {
        public event EventHandler<CustomEventArgument> OnChange = delegate { };

        public void Raise()
        {
            OnChange(this, new CustomEventArgument(255));
        }
    }

    public class EventBehaviour
    {
        public void CreateAndRaise()
        {
            Pub pub = new Pub(); //initialize

            pub.OnChange += (sender, e) => Console.WriteLine($"First event is raised with value: {e.Value}"); //subscribe

            pub.Raise(); //raises subscribed events
        }
    }
}
