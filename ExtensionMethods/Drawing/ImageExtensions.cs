using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Drawing
{
    public static class ImageExtensions
    {
        /// <summary>
        /// 图片剪切
        /// </summary>
        /// <param name="this">Image</param>
        /// <param name="width">裁剪宽度</param>
        /// <param name="height">裁剪高度</param>
        /// <param name="x">左上角X坐标</param>
        /// <param name="y">左上角Y坐标</param>
        public static Image Cut(this Image @this, int width, int height, int x, int y)
        {
            var r = new Bitmap(width, height);
            var destinationRectange = new Rectangle(0, 0, width, height);
            var sourceRectangle = new Rectangle(x, y, width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.DrawImage(@this, destinationRectange, sourceRectangle, GraphicsUnit.Pixel);
            }

            return r;
        }

        /// <summary>
        /// 图片缩放
        /// </summary>
        /// <param name="this">Image</param>
        /// <param name="ratio">缩放比例</param>
        public static Image Scale(this Image @this, double ratio)
        {
            int width = Convert.ToInt32(@this.Width * ratio);
            int height = Convert.ToInt32(@this.Height * ratio);

            var r = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(@this, 0, 0, width, height);
            }

            return r;
        }

        /// <summary>
        /// 图片缩放
        /// </summary>
        /// <param name="this">Image</param>
        /// <param name="width">缩放宽度</param>
        /// <param name="height">缩放高度/param>
        public static Image Scale(this Image @this, int width, int height)
        {
            var r = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(r))
            {
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                g.DrawImage(@this, 0, 0, width, height);
            }

            return r;
        }
    }
}
