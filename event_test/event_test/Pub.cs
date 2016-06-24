using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace event_test
{
    public delegate void msgEventHandler();

   class Pub
    {
        public event msgEventHandler onmsgrecieved;

        public void recievemsg() {

            onmsgrecieved();

        }

    }
}
