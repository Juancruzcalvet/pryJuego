using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmJuego
{
    public partial class frmJuego : Form
    {
        claseNave objNaveJugador;
        public frmJuego()
        {
            InitializeComponent();
        }
        int x = 450;
        int y = 400;
        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();
            objNaveJugador.CrearJugador();
            Controls.Add(objNaveJugador.imagNave);
            objNaveJugador.imagNave.Location = new Point(x, y);
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                x = x + 25;
                objNaveJugador.imagNave.Location = new Point(x, y);
            }
            if(e.KeyCode == Keys.Left)
            {
                x = x - 25;
                objNaveJugador.imagNave.Location = new Point(x, y);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            objNaveJugador = new claseNave();
            
            objNaveJugador.CrearEnemigo();
            Random xEnemigo = new Random();
            int num = xEnemigo.Next( 50, 900);
            objNaveJugador.imagNaveEnemigo.Location = new Point(num, 50);
            Controls.Add(objNaveJugador.imagNaveEnemigo);
        }
    }
}
