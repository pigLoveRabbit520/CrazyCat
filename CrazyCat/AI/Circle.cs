using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CrayzyCat.AI
{
    class Circle : ICloneable
    {
        /// <summary>
        /// 是否被选中了
        /// </summary>
        public bool IsSelected { get; set; }

        /// <summary>
        /// 左上角的圆的坐标
        /// </summary>
        public Point TopLeft { get; set; }

        /// <summary>
        /// 右上角的圆的坐标
        /// </summary>
        public Point TopRight { get; set; }

        /// <summary>
        /// 左边的圆的坐标
        /// </summary>
        public Point Left { get; set; }

        /// <summary>
        /// 右边的圆的坐标
        /// </summary>
        public Point Right { get; set; }

        /// <summary>
        /// 左下角的圆的坐标
        /// </summary>
        public Point BottomLeft { get; set; }

        /// <summary>
        /// 右下角的圆的坐标
        /// </summary>
        public Point BottomRight { get; set; }



        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
