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
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
            #region MacacosPersonagens //Vida,Defesa,Dano,Habilidade Extra
            PersonagensStatus statusGuerreiro = new PersonagensStatus(100, 35, 15, "Investida Heroica");
            Personagem Guerreiro = new Personagem("Macaco Guerreiro", statusGuerreiro);

            PersonagensStatus statusSoldado = new PersonagensStatus(100, 20, 20, "Formação de Escudo");
            Personagem Soldado = new Personagem("Macaco Soldado", statusSoldado);

            PersonagensStatus statusLutador = new PersonagensStatus(100, 15, 30, "Golpe Devastador");
            Personagem Lutador = new Personagem("Macaco Lutador", statusLutador);

            PersonagensStatus StatusMafioso = new PersonagensStatus(100, 15, 20, "Extorsão");
            Personagem Mafioso = new Personagem("Macaco Guerreiro", StatusMafioso);
            #endregion
        }
    }
}
