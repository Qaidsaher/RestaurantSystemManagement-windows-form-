using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RestaurantSystemManagement
{
    public partial class CustomPanel : UserControl
    {
        public CustomPanel()
        {
            InitializeComponent();
            
            SetRegion();
            this.Resize += delegate
            {
                SetRegion();
            };
        }

  
        private int cornerRadiusTopLeft = 5;
        private int cornerRadiusTopRight = 5;
        private int cornerRadiusBottomLeft = 5;
        private int cornerRadiusBottomRight = 5;

        public int CornerRadius
        {
            get { return cornerRadiusTopLeft; }
            set
            {
                cornerRadiusTopLeft = cornerRadiusTopRight = cornerRadiusBottomLeft = cornerRadiusBottomRight = value;
                SetRegion();
            }
        }

        

        

        private void SetRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadiusTopLeft * 2, cornerRadiusTopLeft * 2, 180, 90);
            path.AddArc(Width - cornerRadiusTopRight * 2, 0, cornerRadiusTopRight * 2, cornerRadiusTopRight * 2, 270, 90);
            path.AddArc(Width - cornerRadiusBottomRight * 2, Height - cornerRadiusBottomRight * 2, cornerRadiusBottomRight * 2, cornerRadiusBottomRight * 2, 0, 90);
            path.AddArc(0, Height - cornerRadiusBottomLeft * 2, cornerRadiusBottomLeft * 2, cornerRadiusBottomLeft * 2, 90, 90);
            path.CloseFigure();
            Region = new Region(path);
        }
    }
}

