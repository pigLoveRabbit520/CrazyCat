using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using CrayzyCat.AI;

namespace CrayzyCat
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            InitialInnercircles();
            w_Offset = (picBoard.Width - (gameSize * (diameter + space) + diameter / 2)) / 2;//画在中央
            h_Offset = picBoard.Height / 3;//高度方向一定的偏移量，使圆画在下方
            DrawGamecircles();
            GetCatFrames(CrayzyCat.Properties.Resources.stay,stayFrames,catWidth,catHeight);
            catWidth = 64;
            catHeight = 91;
            GetCatFrames(CrayzyCat.Properties.Resources.encircle, encircleFrames, catWidth, catHeight);
            picCat.Parent = picBoard;
            picMainReplay.Parent = picBoard;
        }


        private Circle[,] circles = new Circle[gameSize, gameSize];//初始值全为0，表示圆的未选中状态
        private const int gameSize = 9;
        private int diameter = 40;//圆的直径
        private int space = 5;//间隙
        private int w_Offset = 0;//画圆时的偏移量
        private int h_Offset = 0;
        private Bitmap[,] stayFrames = new Bitmap[4, 4];//在圆圈上停留的帧
        private Bitmap[,] encircleFrames = new Bitmap[4, 4];//被包围后的帧
        private int frameRow, frameCol;
        private int shakeType = 0;//摇动的类型，0表示停留的动画，1表示被包围的动画
        private int catHeight = 93;
        private int catWidth = 61;
        private int catRow = 0;//小猫的内部标识的位置
        private int catCol = 0;
        


        /// <summary>
        /// 初始化内部circles数组的信息
        /// </summary>
        private void InitialInnercircles()
        {
            for (int i = 0; i < gameSize; i++)
            {
                for (int j = 0; j < gameSize; j++)
                {
                    circles[i, j] = new Circle();
                    circles[i, j].IsSelected = false;
                    if (i % 2 == 0)
                    {
                        circles[i, j].TopLeft = new Point(i - 1, j - 1);
                        circles[i, j].TopRight = new Point(i - 1, j);
                        circles[i, j].BottomLeft = new Point(i + 1, j - 1);
                        circles[i, j].BottomRight = new Point(i + 1, j);
                    }
                    else
                    {
                        circles[i, j].TopLeft = new Point(i - 1, j);
                        circles[i, j].TopRight = new Point(i - 1, j + 1);
                        circles[i, j].BottomLeft = new Point(i + 1, j);
                        circles[i, j].BottomRight = new Point(i + 1, j + 1);
                    }
                    circles[i, j].Left = new Point(i, j - 1);
                    circles[i, j].Right = new Point(i, j + 1);
                }
            }
        }


        /// <summary>
        /// 截取小猫运动帧
        /// </summary>
        /// <param name="source"></param>
        /// <param name="Frames"></param>
        private void GetCatFrames(Bitmap source,Bitmap[,] frames,int catWidth,int catHeight)
        {
            for(int i=0;i<4;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Bitmap bmp = new Bitmap(catWidth, catHeight);
                    Rectangle srcRect = new Rectangle(j * catWidth, i * catHeight, catWidth, catHeight);
                    Rectangle destRect = new Rectangle(0, 0, catWidth, catHeight);
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawImage(source, destRect, srcRect, GraphicsUnit.Pixel);
                    frames[i, j] = bmp;
                    g.Dispose();
                }
            }
        }

        /// <summary>
        /// 一定时间换帧，形成动画效果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrShake_Tick(object sender, EventArgs e)
        {
            if(shakeType==0)
            {
                frameCol++;
                if (frameCol == 4)
                {
                    frameRow++;
                    frameCol = 0;
                    if (frameRow == 4)
                    {
                        frameRow = 0;
                    }
                }
                picCat.Image = stayFrames[frameRow, frameCol];
            }
            else
            {
                frameCol++;
                if (frameCol == 4 && frameRow <= 2)
                {
                    frameCol = 0;
                    frameRow++;
                }
                if(frameCol==3&&frameRow==3)
                {
                    frameCol = 0;
                    frameRow = 0;
                }
                picCat.Image = encircleFrames[frameRow, frameCol];
            }
            
        }


        /// <summary>
        /// 画出游戏所需的未选中状态所有的实心圆
        /// </summary>
        private void DrawGamecircles()
        {
            Bitmap bmp = new Bitmap(picBoard.Width, picBoard.Height);
            Graphics g = Graphics.FromImage(bmp);
            SolidBrush myBrush = new SolidBrush(Color.FromArgb(181, 181, 181));
            for (int i = 0; i < gameSize; i++)
            {
                for (int j = 0; j < gameSize; j++)
                {
                    Rectangle rect = new Rectangle((diameter + space) * j + w_Offset + (diameter / 2) * (i % 2), diameter * i + h_Offset, diameter, diameter);
                    g.FillEllipse(myBrush, rect);
                }
            }
            picBoard.Image = bmp;
            myBrush.Dispose();
            g.Dispose();
        }

        /// <summary>
        /// 根据鼠标点击的位置计算出内部标识
        /// </summary>
        /// <param name="x">鼠标点击的X坐标</param>
        /// <param name="y">鼠标点击的Y坐标</param>
        /// <returns></returns>
        private Point GetInnerMark(int x,int y)
        {
            int row = -1, col = -1;//真正用到的内部标记
            for (int i = 0; i < gameSize; i++)
            {
                for (int j = 0; j < gameSize; j++)
                {
                    int circle_CenterX = (diameter + space) * j + w_Offset + diameter / 2 * (i % 2 + 1);//圆心坐标
                    int circle_CenterY = diameter * i + h_Offset + diameter / 2;
                    int distance = (circle_CenterX - x) * (circle_CenterX - x) + (circle_CenterY - y) * (circle_CenterY - y);
                    if (distance < diameter * diameter / 4)
                    {
                        row = i;
                        col = j;
                        i = gameSize;
                        break;
                    }
                }
            }
            return new Point(row, col);
        }

       
        /// <summary>
        /// 画出选中状态的实心圆
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void DrawSelectedCircle(int row,int col)
        {
            Graphics g = Graphics.FromImage(picBoard.Image);
            SolidBrush myBrush = new SolidBrush(Color.FromArgb(255, 132, 94));
            Rectangle rect = new Rectangle((diameter + space) * col + w_Offset + (diameter / 2) * (row % 2), diameter * row + h_Offset, diameter, diameter);
            g.FillEllipse(myBrush, rect);
            picBoard.Refresh();
            myBrush.Dispose();
            g.Dispose();
        }

        /// <summary>
        /// 移动小猫的算法，利用广度优先的思想
        /// </summary>
        /// <returns></returns>
        private bool SearchBestPath()
        {
            int i=0,j=0,di=0;
            bool find=false;
            Circle[,] map = new Circle[gameSize, gameSize];
            CloneMap(map);//克隆一份地图
            QuType qu = new QuType();//定义顺序队
            qu.Front = qu.Rear = -1;
            qu.Rear++;
            qu.Data.Add(new Box { Circle = circles[catRow, catCol], Pre = -1, Row = catRow, Col = catCol });//小猫现在的位置进队
            map[catRow, catCol].IsSelected = true;//避免重复搜索
            while (qu.Front != qu.Rear && !find)
            {
                qu.Front++;
                i = qu.Data[qu.Front].Row;
                j = qu.Data[qu.Front].Col;
                if(i==0||j==0||i==gameSize-1||j==gameSize-1)
                {
                    find = true;
                    GetBestPath(qu,qu.Front);
                    return true;
                }
                for(di=0;di<6;di++)//六个方向遍历
                {
                    switch(di)
                    {
                        case 0: i = qu.Data[qu.Front].Circle.TopLeft.X; j = qu.Data[qu.Front].Circle.TopLeft.Y; break;
                        case 1: i = qu.Data[qu.Front].Circle.TopRight.X; j = qu.Data[qu.Front].Circle.TopRight.Y; break;
                        case 2: i = qu.Data[qu.Front].Circle.Left.X; j = qu.Data[qu.Front].Circle.Left.Y; break;
                        case 3: i = qu.Data[qu.Front].Circle.Right.X; j = qu.Data[qu.Front].Circle.Right.Y; break;
                        case 4: i = qu.Data[qu.Front].Circle.BottomLeft.X; j = qu.Data[qu.Front].Circle.BottomLeft.Y; break;
                        case 5: i = qu.Data[qu.Front].Circle.BottomRight.X; j = qu.Data[qu.Front].Circle.BottomRight.Y; break;
                    }
                    if(!map[i,j].IsSelected)
                    {
                        qu.Rear++;
                        qu.Data.Add(new Box { Circle = circles[i, j], Pre = qu.Front, Row = i, Col = j });
                        map[i, j].IsSelected = true;//避免回过来重复搜索
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 复制一个地图
        /// </summary>
        /// <param name="map"></param>
        private void CloneMap(Circle[,] map)
        {
            for (int i = 0; i < gameSize; i++)
            {
                for (int j = 0; j < gameSize; j++)
                {
                    map[i, j] = (Circle)circles[i, j].Clone();
                }
            }
        }

        /// <summary>
        /// 获取最贪心的路径
        /// </summary>
        /// <param name="qu"></param>
        /// <param name="front"></param>
        private void GetBestPath(QuType qu,int front)
        {
            List<Box> path=new List<Box>();
            int k = front, j = 0;
            do
            {
                j = k;
                k = qu.Data[k].Pre;
                qu.Data[j].Pre = -1;
            } while (k != 0);
            k = 0;
            while(k<qu.Data.Count)//正向搜索到pre为-1的方块，即构成正向的路径
            {
                if (qu.Data[k].Pre == -1)
                {
                    path.Add(qu.Data[k]);
                }
                k++;
            }
            catRow = path[1].Row;
            catCol = path[1].Col;
            SetCatPos(catRow, catCol);
        }


        /// <summary>
        /// 移动被包围的小猫
        /// </summary>
        /// <returns></returns>
        private bool MoveEncircledCat()
        {
            Random r = new Random();
            int row = 0, col = 0;
            for (int i = 0; i < 6; i++)
            {
                switch (i)
                {
                    case 0: row = circles[catRow, catCol].TopLeft.X; col = circles[catRow, catCol].TopLeft.Y; break;
                    case 1: row = circles[catRow, catCol].TopRight.X; col = circles[catRow, catCol].TopRight.Y; break;
                    case 2: row = circles[catRow, catCol].Left.X; col = circles[catRow, catCol].Left.Y; break;
                    case 3: row = circles[catRow, catCol].Right.X; col = circles[catRow, catCol].Right.Y; break;
                    case 4: row = circles[catRow, catCol].BottomLeft.X; col = circles[catRow, catCol].BottomLeft.Y; break;
                    case 5: row = circles[catRow, catCol].BottomRight.X; col = circles[catRow, catCol].BottomRight.Y; break;
                }
                if (!circles[row, col].IsSelected)
                {
                    catRow = row;
                    catCol = col;
                    SetCatPos(catRow, catCol);
                    return true;
                }
            }
            return false;
        }


        /// <summary>
        /// 设置路障
        /// </summary>
        private void InitialMap()
        {
            Random r = new Random();
            int barrier = r.Next(6, 13);//路障的数目为6到12个
            for (int i = 0; i < barrier; )
            {
                int row = r.Next(0, gameSize);
                int col = r.Next(0, gameSize);
                if (row == gameSize / 2 && col == gameSize / 2)//小猫的起始点不能取
                    continue;
                if (!circles[row, col].IsSelected)
                {
                    circles[row, col].IsSelected = true;
                    DrawSelectedCircle(row, col);
                    i++;
                }
            }
        }



        /// <summary>
        /// 根据内部标识来设置小猫的位置
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        private void SetCatPos(int row, int col)
        {
            int circle_CenterX = (diameter + space) * col + w_Offset + (diameter / 2) * (row % 2 + 1);//圆心坐标
            int circle_CenterY = diameter * row + h_Offset + diameter / 2;
            picCat.Location = new Point(circle_CenterX - picCat.Width / 2, circle_CenterY - picCat.Height);

        }

       /// <summary>
        /// 清除各种路障
       /// </summary>
       /// <param name="circles"></param>
        private void ClearBarriers(Circle[,] circles)
        {
            for (int i = 0; i < gameSize; i++)
            {
                for (int j = 0; j < gameSize; j++)
                {
                    if(circles[i, j].IsSelected)
                    {
                        circles[i, j].IsSelected = false;
                    }
                }
            }
            DrawGamecircles();
        }


        private void picBoard_MouseClick(object sender, MouseEventArgs e)
        {
            Point innerPos = GetInnerMark(e.X, e.Y);
            if (innerPos.X == -1 && innerPos.Y == -1)//无效点
                return;
            if (!circles[innerPos.X, innerPos.Y].IsSelected)
            {
                circles[innerPos.X, innerPos.Y].IsSelected = true;
                DrawSelectedCircle(innerPos.X, innerPos.Y);

                UserInfo.PlayerClickNum++;
                
                if (catRow == 0 || catCol == 0 || catRow == gameSize - 1 || catCol == gameSize - 1)
                {
                    frmFail frm = new frmFail();
                    frm.ShowDialog();
                    if (frm.DialogResult == DialogResult.OK)
                    {
                        picReplay_Click(this, new EventArgs());
                        UserInfo.PlayerClickNum = 0;//步数置空
                    }
                    return;
                }
                //移动小猫
                if(!SearchBestPath())
                {
                    shakeType = 1;
                    frameRow = 0;
                    frameCol = 0;
                    if(!MoveEncircledCat())
                    {
                        frmVictory frm = new frmVictory();
                        frm.ShowDialog();
                        if(frm.DialogResult==DialogResult.OK)
                        {
                            picReplay_Click(this, new EventArgs());
                            UserInfo.PlayerClickNum = 0;//步数置空
                            shakeType = 0;
                        }
                    }
                }
            }
        }


        private void picCat_MouseClick(object sender, MouseEventArgs e)
        {
            int x_Offset = picCat.Location.X;
            int y_Offset = picCat.Location.Y;
            MouseEventArgs myMouseEventArgs = new MouseEventArgs(e.Button, e.Clicks, e.X + x_Offset, e.Y + y_Offset, e.Delta);
            picBoard_MouseClick(picCat, myMouseEventArgs);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitialMap();
            catRow = gameSize / 2;
            catCol = gameSize / 2;
            SetCatPos(gameSize / 2, gameSize / 2);
        }

        private void picReplay_Click(object sender, EventArgs e)
        {
            ClearBarriers(circles);
            InitialMap();
            catRow = gameSize / 2;
            catCol = gameSize / 2;
            SetCatPos(gameSize / 2, gameSize / 2);
            UserInfo.PlayerClickNum = 0;
        }

        private void picReplay_MouseEnter(object sender, EventArgs e)
        {
            picMainReplay.Padding = new Padding(3);
            picMainReplay.Invalidate();
        }

        private void picReplay_MouseLeave(object sender, EventArgs e)
        {
            picMainReplay.Padding = new Padding(0);
            picMainReplay.Invalidate();
        }

        


        
    }
}
