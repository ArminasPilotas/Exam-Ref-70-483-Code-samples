using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Ref_80_483
{
    public class ReflectionUsage
    {
        public void Run() //TODO is this creates instances of implemented interface classes?
        {
            Assembly pluginAssembly = Assembly.Load("CreateAndUseTypes"); //loads assembly by it's name

            var plugins = from type in pluginAssembly.GetTypes()
                          where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                          select type;

            foreach (Type pluginType in plugins)
            {
                IPlugin plugin = (IPlugin)Activator.CreateInstance(pluginType);
            }
        }

        public void ExecuteMethod(int comparable)
        {
            int i = 40;

            MethodInfo compareToMethod = i.GetType().GetMethod("CompareTo", new Type[] { typeof(int) });

            int result = (int)compareToMethod.Invoke(i, new object[] { comparable });

            Console.WriteLine(result);
        }
    }

    public class MyApplication
    {

    }

    public interface IPlugin
    {
        string Name { get; }
        string Description { get; }
        bool Load(MyApplication application);
    }

    public class MyPlugin : IPlugin
    {
        public string Name
        {
            get { return "MyPlugin"; }
        }

        public string Description
        {
            get { return "My Sample Plugin"; }
        }

        public bool Load(MyApplication application)
        {
            return true;
        }
    }
}
