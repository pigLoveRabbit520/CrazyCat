using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrayzyCat.AI
{

    /// <summary>
    /// 一个队列的类
    /// </summary>
    class QuType
    {

        public List<Box> Data = new List<Box>();

        //队首和队尾指针
        public int Front { get; set; }
        public int Rear { get; set; }
    }
}
