using System.Drawing;

namespace noiseGenerator
{
    public static class Utils
    {
        public static bool LeftUpperCornerNotEqualsColor(this Bitmap bmp, int x, int y, Color _c)
        {
            int c = _c.ToArgb();
            bool ret = //bmp.GetPixel(x - 1, y - 1).ToArgb() != c && 
                bmp.GetPixel(x - 1, y).ToArgb() != c && bmp.GetPixel(x, y - 1).ToArgb() != c;
            return ret;
        }

        public static bool LeftBottomCornerNotEqualsColor(this Bitmap bmp, int x, int y, Color _c)
        {
            int c = _c.ToArgb();
            bool ret = //bmp.GetPixel(x - 1, y + 1).ToArgb() != c && 
                bmp.GetPixel(x - 1, y).ToArgb() != c && bmp.GetPixel(x, y + 1).ToArgb() != c;
            return ret;
        }

        public static bool RightUpperCornerNotEqualsColor(this Bitmap bmp, int x, int y, Color _c)
        {
            int c = _c.ToArgb();
            bool ret = //bmp.GetPixel(x + 1, y - 1).ToArgb() != c && 
                bmp.GetPixel(x + 1, y).ToArgb() != c && bmp.GetPixel(x, y - 1).ToArgb() != c;
            return ret;
        }

        public static bool RightBottomCornerNotEqualsColor(this Bitmap bmp, int x, int y, Color _c)
        {
            int c = _c.ToArgb();
            bool ret = //bmp.GetPixel(x + 1, y + 1).ToArgb() != c && 
                bmp.GetPixel(x + 1, y).ToArgb() != c && bmp.GetPixel(x, y + 1).ToArgb() != c;
            return ret;
        }
    }
}
