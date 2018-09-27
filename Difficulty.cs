using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon_Says2
{
    public class Difficulty
    {
        public int delay;
        public int color;



        public Difficulty(int difficulty=1) {


            switch (difficulty)
            {
                case 1:
                    delay = 500;
                    color = 4;
                    break;
                case 2:
                    delay = 300;
                     color = 4;
                    break;
                case 3:
                     delay = 200;
                     color = 4;
                    break;
                default:
                    break;
                
            }
        }
    }
}
