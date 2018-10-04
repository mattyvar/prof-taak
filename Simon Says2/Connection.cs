using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EV3WifiLib;
using System.Net;

namespace Simon_Says2
{
    public class Connection
    {
        private EV3Wifi myEV3;
        public int color;
        // You need a timer to receive messages from the EV3
        // at specified time intervals.
        // private Timer messageReceiveTimer;
        public Connection(int color)
        {
            switch (color)
            {
                case 0:

                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;

            }

        }
    }
}
