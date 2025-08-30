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
    public partial class CustomButton : UserControl
    {
        public event EventHandler Click;
        public Image image{get => this.icon.Image; set => this.icon.Image = value;}
        public  Font font { get => this.label.Font; set => this.label.Font = value; }
        public Color bkColor { get => this.label.BackColor; set => this.label.BackColor = value; }
        public Color frColor { get => this.label.ForeColor; set => this.label.ForeColor = value; }
        public string text { get => this.label.Text;set =>this.label.Text = value; }
        private int cornerRadius = 5;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                SetRegion();
            }
        }

        private void SetRegion()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(Width - cornerRadius * 2, Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();

            Region = new Region(path);
        }
    

       public CustomButton()
        {
            InitializeComponent();
            this.label.Click += childclick;
            this.icon.Click += childclick;
            this.AutoSize = false;
            SetRegion();
            this.Resize += delegate { SetRegion(); };

        }
        private void childclick(Object sender,EventArgs e)
        {
            OnClick();
        }
        protected virtual void OnClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
