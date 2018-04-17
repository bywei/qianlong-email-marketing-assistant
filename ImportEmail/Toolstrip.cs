using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace common
{
    public class Toolstrip : ToolStripRenderer
    {
        private int i;
        public Toolstrip()
        {
        }

        protected override void InitializeItem(ToolStripItem item)
        {
            base.InitializeItem(item);
            item.AutoSize = false;
            item.Height = 30;
            item.Padding = new Padding(5);
            item.Margin = new Padding(0, 0, 0, 1);
            if (item is ToolStripButton)
            {
                ToolStripButton btn = item as ToolStripButton;
                item.Width = 30;
            }

        }

        #region //绘制按钮
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            bool chk = false;
            chk = (e.Item as ToolStripButton).Checked;
            if (e.Item.Pressed && e.Item.Selected)
            {
                i = 2;
            }
            else if (e.Item.Selected)
            {
                i = 1;
            }
            else if (chk)
            {
                i = 2;
            }
            else
            { i = 0; }
            ImageDrawRect.DrawRect(e.Graphics, global::common.Properties.Resources.main_tabbtn, new Rectangle(Point.Empty, e.Item.Size), Rectangle.FromLTRB(5, 15, 5, 5), i, 2);
        }
        #endregion
    }

    public partial class ImageDrawRect
    {

        /// <summary>
        /// 绘图对像
        /// </summary>
        /// <param name="g">绘图对像</param>
        /// <param name="img">图片</param>
        /// <param name="r">绘置的图片大小、坐标</param>
        /// <param name="lr">绘置的图片边界</param>
        /// <param name="index">当前状态</param> 
        /// <param name="Totalindex">状态总数</param>
        public static void DrawRect(Graphics g, Bitmap img, Rectangle r, Rectangle lr, int index, int Totalindex)
        {
            if (img == null) return;
            Rectangle r1, r2;
            int x = (index - 1) * img.Width / Totalindex;
            int y = 0;
            int x1 = r.Left;
            int y1 = r.Top;

            if (r.Height > img.Height && r.Width <= img.Width / Totalindex)
            {
                r1 = new Rectangle(x, y, img.Width / Totalindex, lr.Top);
                r2 = new Rectangle(x1, y1, r.Width, lr.Top);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                r1 = new Rectangle(x, y + lr.Top, img.Width / Totalindex, img.Height - lr.Top - lr.Bottom);
                r2 = new Rectangle(x1, y1 + lr.Top, r.Width, r.Height - lr.Top - lr.Bottom);
                if ((lr.Top + lr.Bottom) == 0) r1.Height = r1.Height - 1;
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                r1 = new Rectangle(x, y + img.Height - lr.Bottom, img.Width / Totalindex, lr.Bottom);
                r2 = new Rectangle(x1, y1 + r.Height - lr.Bottom, r.Width, lr.Bottom);
                g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
            }
            else
                if (r.Height <= img.Height && r.Width > img.Width / Totalindex)
                {
                    r1 = new Rectangle(x, y, lr.Left, img.Height);
                    r2 = new Rectangle(x1, y1, lr.Left, r.Height);
                    g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
                    r1 = new Rectangle(x + lr.Left, y, img.Width / Totalindex - lr.Left - lr.Right, img.Height);
                    r2 = new Rectangle(x1 + lr.Left, y1, r.Width - lr.Left - lr.Right, r.Height);
                    g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
                    r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y, lr.Right, img.Height);
                    r2 = new Rectangle(x1 + r.Width - lr.Right, y1, lr.Right, r.Height);
                    g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
                }
                else
                    if (r.Height <= img.Height && r.Width <= img.Width / Totalindex)
                    {
                        r1 = new Rectangle((index - 1) * img.Width / Totalindex, 0, img.Width / Totalindex, img.Height - 1);
                        g.DrawImage(img, new Rectangle(x1, y1, r.Width, r.Height), r1, GraphicsUnit.Pixel);
                    }
                    else if (r.Height > img.Height && r.Width > img.Width / Totalindex)
                    {
                        //top-left
                        r1 = new Rectangle(x, y, lr.Left, lr.Top);
                        r2 = new Rectangle(x1, y1, lr.Left, lr.Top);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //top-bottom
                        r1 = new Rectangle(x, y + img.Height - lr.Bottom, lr.Left, lr.Bottom);
                        r2 = new Rectangle(x1, y1 + r.Height - lr.Bottom, lr.Left, lr.Bottom);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //left
                        r1 = new Rectangle(x, y + lr.Top, lr.Left, img.Height - lr.Top - lr.Bottom);
                        r2 = new Rectangle(x1, y1 + lr.Top, lr.Left, r.Height - lr.Top - lr.Bottom);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //top
                        r1 = new Rectangle(x + lr.Left, y,
                            img.Width / Totalindex - lr.Left - lr.Right, lr.Top);
                        r2 = new Rectangle(x1 + lr.Left, y1,
                            r.Width - lr.Left - lr.Right, lr.Top);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //right-top
                        r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y, lr.Right, lr.Top);
                        r2 = new Rectangle(x1 + r.Width - lr.Right, y1, lr.Right, lr.Top);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //Right
                        r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y + lr.Top,
                            lr.Right, img.Height - lr.Top - lr.Bottom);
                        r2 = new Rectangle(x1 + r.Width - lr.Right, y1 + lr.Top,
                            lr.Right, r.Height - lr.Top - lr.Bottom);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //right-bottom
                        r1 = new Rectangle(x + img.Width / Totalindex - lr.Right, y + img.Height - lr.Bottom,
                            lr.Right, lr.Bottom);
                        r2 = new Rectangle(x1 + r.Width - lr.Right, y1 + r.Height - lr.Bottom,
                            lr.Right, lr.Bottom);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //bottom
                        r1 = new Rectangle(x + lr.Left, y + img.Height - lr.Bottom,
                            img.Width / Totalindex - lr.Left - lr.Right, lr.Bottom);
                        r2 = new Rectangle(x1 + lr.Left, y1 + r.Height - lr.Bottom,
                            r.Width - lr.Left - lr.Right, lr.Bottom);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);

                        //Center
                        r1 = new Rectangle(x + lr.Left, y + lr.Top,
                            img.Width / Totalindex - lr.Left - lr.Right, img.Height - lr.Top - lr.Bottom);
                        r2 = new Rectangle(x1 + lr.Left, y1 + lr.Top,
                            r.Width - lr.Left - lr.Right, r.Height - lr.Top - lr.Bottom);
                        g.DrawImage(img, r2, r1, GraphicsUnit.Pixel);
                    }
        }
    }
}
