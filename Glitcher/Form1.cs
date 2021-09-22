using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glitcher
{
    public partial class Form1 : Form
    {
        private Random _rnd;
        private Graphics _graphics;
        private Bitmap _screenshot;
        private Bitmap _orig;
        private int _alpha = 115;

        public Form1()
        {
            InitializeComponent();

            Start();
        }

        private void Start()
        {
            _rnd = new Random();

            _graphics = Picture.CreateGraphics();

            _orig = new Bitmap(@"Resources/Screenshot_3.png");
            _graphics.DrawImage(_orig, 0, 0);

            _screenshot = new Bitmap(Picture.Image);
        }


        private void Load_Button_Click(object sender, EventArgs e)
        {

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {

        }

        private void Glitch_Button_Click(object sender, EventArgs e)
        {
            _alpha = AlphaTrackBar.Value;

            _graphics.Clear(Color.Black);
            _graphics.DrawImage(_orig, 0, 0);

            
            int SpanX, SpanY, SpanHeight;

            

            for (int i = 0; i < 25; i++)
            {
                SpanHeight = _rnd.Next(4, 123);
                if (_rnd.Next(0, 5) == 0)
                {
                    SpanX = _rnd.Next(-60, 60);
                }
                else
                {
                    SpanX = _rnd.Next(-15, 15);
                }
                SpanY = _rnd.Next(0, _screenshot.Height);



                _graphics.DrawImage(_screenshot, new RectangleF(SpanX, SpanY, _screenshot.Width, SpanHeight), new RectangleF(0, SpanY, _screenshot.Width, SpanHeight), GraphicsUnit.Pixel);
                if (_rnd.Next(0, 11) != 0)
                {
                    _graphics.FillRectangle(new SolidBrush(Color.FromArgb(_alpha, 245, 171, 0)), new Rectangle(0, SpanY, _screenshot.Width, SpanHeight));
                }

                if (_rnd.Next(0, 4) != 0)
                {
                    _graphics.FillRectangle(new SolidBrush(Color.FromArgb(_alpha, 33, 219, 36)), new Rectangle(0, SpanY, _screenshot.Width, SpanHeight));
                }
            }
           

            //_graphics.DrawImage(Picture.Image, 0, 0);
        }
    }
}
