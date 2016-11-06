using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoItYourselfIoC.DiYIoC
{
    public static class DiyIoC
    {
        private static readonly Dictionary<Type, object> container;

        static DiyIoC()
        {
            container = new Dictionary<Type, object>();
        }

        public static void Register<T>(T obj)
        {
            container.Add(typeof(T), obj);
        }

        public static T Resolve<T>()
        {
            return (T)container[typeof(T)];
        }
    }
}
