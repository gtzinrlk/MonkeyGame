using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Jogo_do_macaco___feira
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (LinearGradientBrush gradientBrush = new LinearGradientBrush(
                new Point(0, 0),
                new Point(ClientSize.Width, 0),
                Color.Purple,
                Color.Red))
            {
                e.Graphics.FillRectangle(gradientBrush, ClientRectangle);
            }
        }
    

    private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_Comecar_MouseHover(object sender, EventArgs e)
        {
            lbl_Comecar.ForeColor = Color.LightGreen;
            lbl_Comecar.Cursor = Cursors.Hand;
        }

        private void lbl_Comecar_Click(object sender, EventArgs e)
        {
            MenuJogo menuJogo = new MenuJogo();
            menuJogo.Show();
            this.Hide();

        }

        private void lbl_Comecar_MouseLeave(object sender, EventArgs e)
        {
            lbl_Comecar.ForeColor = Color.Black;
            lbl_Comecar.Cursor = Cursors.Default;
        }

        private void lbl_Rank_MouseLeave(object sender, EventArgs e)
        {
            lbl_Rank.ForeColor = Color.Black;
            lbl_Rank.Cursor = Cursors.Default;
        }

        private void lbl_Rank_MouseHover(object sender, EventArgs e)
        {
            lbl_Rank.ForeColor = Color.LightGreen;
            lbl_Rank.Cursor = Cursors.Hand;
        }

        private void lbl_Sair_MouseHover(object sender, EventArgs e)
        {
            lbl_Sair.ForeColor = Color.LightGreen;
            lbl_Sair.Cursor = Cursors.Hand;
        }

        private void lbl_Sair_MouseLeave(object sender, EventArgs e)
        {
            lbl_Sair.ForeColor = Color.Black;
            lbl_Sair.Cursor = Cursors.Default;
        }
    }
}
