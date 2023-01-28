using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Main
{
    public class Service
    {
        public int a;
        private int b;

        private static Service _instance;

        private Service(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public static Service GetService(int a, int b)
        {
            _instance=_instance??new Service(a, b);
            return _instance;
        }
    }
}
