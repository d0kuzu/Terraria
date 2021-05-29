using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект
{
    public partial class Form2 : Form
    {
        Rectangle Background = new Rectangle(0, 0, 900, 500);
        Rectangle SP = new Rectangle(315, 180, 300, 50);
        Rectangle Exit = new Rectangle(395, 240, 130, 45);

        public Form2()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.DrawImage(Resource1.menu, Background);
            g.DrawImage(Resource1.SP, SP);
            g.DrawImage(Resource1.Exit, Exit);
            var local_position = this.PointToClient(Cursor.Position);
            if (local_position.X >= SP.X && local_position.X <= SP.X + 300 && local_position.Y >= SP.Y && local_position.Y <= SP.Y + 50)
            {
                g.DrawImage(Resource1.SP1, SP);
            }
            else
            {
                if (local_position.X < SP.X && local_position.X > SP.X + 300 && local_position.Y < SP.Y && local_position.Y > SP.Y + 50)
                {
                    g.DrawImage(Resource1.SP, SP);
                }
                if (local_position.X >= Exit.X && local_position.X <= Exit.X + 130 && local_position.Y >= Exit.Y && local_position.Y <= Exit.Y + 45)
                {
                    g.DrawImage(Resource1.Exit1, Exit);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();            
        }
        private void Form2_Click(object sender, EventArgs e)
        {
            var local_position = this.PointToClient(Cursor.Position);
            if (local_position.X >= SP.X && local_position.X <= SP.X + 300 && local_position.Y >= SP.Y && local_position.Y <= SP.Y + 50)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            if (local_position.X >= Exit.X && local_position.X <= Exit.X + 130 && local_position.Y >= Exit.Y && local_position.Y <= Exit.Y + 45)
            {
                Application.Exit();
            }
        }
    }
}
