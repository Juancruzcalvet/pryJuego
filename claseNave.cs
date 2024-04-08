using NPoco.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmJuego
{
    internal class claseNave
    {
        //carecteristicas de las naves
        int vida;
        string jugador;
        int daño;
        public PictureBox imagNave;
        public PictureBox imagNaveEnemigo;
        public void CrearJugador()
        {
            vida = 100;
            jugador = "player";
            daño = 1;
            imagNave = new PictureBox();
            imagNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imagNave.ImageLocation = "https://www.kindpng.com/picc/m/210-2102031_galaga-ship-no-background-png-download-8-bit.png";


        }
        public void CrearEnemigo()
        {
            vida = 1;
            jugador = "enemigo1";
            daño = 25;
            imagNaveEnemigo = new PictureBox();
            imagNaveEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
            imagNaveEnemigo.ImageLocation = "https://us.123rf.com/450wm/djvstock/djvstock2005/djvstock200541513/147633639-dise%C3%B1o-de-ilustraci%C3%B3n-de-vector-de-icono-de-juego-de-nave-espacial-pixelada.jpg?ver=6";

        }

    }
}
