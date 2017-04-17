using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrayzyCat.AI
{
    class Box
    {
        public Circle Circle { get; set; }
        public int Pre { get; set; }//本路径中上一方块在队列中的下标

        public int Row { get; set; }
        public int Col { get; set; }
    }
}
