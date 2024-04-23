using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmJuego
{
    internal class clsEnemigo
    {
        //Propiedades del enemigo
        public PictureBox pctEnemigo;
        public int vida;
        //Metodos del enemigo(tienen distintos movimientos que el jugador, automáticos)
        public void Spawn(frmJuego frmJuego) //Aqui decidimos el aparecimiento de enemigos.
        {
            pctEnemigo = new PictureBox(); //Su foto
            Random random = new Random(); //Aleatorio para decidir que enemigo vendrá
            random.Next(1, 3);
            int randomx = random.Next(0, frmJuego.ClientSize.Width - 80); //Posicion aleatoria del enemigo al aparecer.
            switch (random.Next(1, 3)) //Aqui se decide que enemigo viene
            {
                case 1:
                    pctEnemigo.Image = Image.FromFile(@"C:\Users\win 10\source\repos\pryJuego\Fotos\Enemigo1.png"); //Foto
                    vida = 1; //Vida, c/disparo deberá quitar 1
                    break; 
                case 2:
                    pctEnemigo.Image = Image.FromFile(@"C:\Users\win 10\source\repos\pryJuego\Fotos\Enemigo1.png");
                    vida = 2;
                    break;

                case 3:
                    pctEnemigo.Image = Image.FromFile(@"C:\Users\win 10\source\repos\pryJuego\Fotos\Enemigo1.png");
                    vida = 3;
                    break;

            }
            pctEnemigo.Size = new Size(80, 80); //Tamaño de la foto del enemigo
            pctEnemigo.SizeMode = PictureBoxSizeMode.StretchImage; 
            pctEnemigo.Location = new Point(randomx, 15);//Aparecen en una X aleatoria, pero su Y es fija
            frmJuego.Controls.Add(pctEnemigo); //Añadimos su foto
            pctEnemigo.BringToFront(); //Lo mandamos al frente del frm, asi se puede ver y nada lo eclipsa.
        }
    }
}
