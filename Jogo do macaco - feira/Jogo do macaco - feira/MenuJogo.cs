using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_do_macaco___feira
{
    public partial class MenuJogo : Form
    {
        public MenuJogo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Personagens formPersonagens = new Personagens();
            formPersonagens.Show();
            this.Hide();

        }
    }
}
