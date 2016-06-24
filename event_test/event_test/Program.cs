using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test
{
    class Program
    {
        static void Main(string[] args)
        {

            var sub = new Sub();
            var pub = new Pub();
            var sub1 = new Sub1();

            pub.onmsgrecieved += sub1.onMsgRecieved;
            pub.onmsgrecieved += sub.msgsent;
            pub.recievemsg();
        }



    }
}


   