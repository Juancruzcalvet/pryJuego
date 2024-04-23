using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Timer = System.Windows.Forms.Timer;
using System.Timers;
using System.Drawing;



namespace frmJuego
{
    public class clsNave
    {
        Timer Timer = new Timer();
        //A partir de este timer se basará el movimiento del juego.

        //Decidimos la cadencia del timer
        public clsNave()
        {
            Timer.Interval = 10;
            Timer.Tick += Timer_Tick;
        }
        public void Movimiento(KeyEventArgs e, PictureBox Jugador)
        {
            PictureBox pctJugador = new PictureBox(); //La nave como objeto instanciado en la memoria(foto)
            pctJugador = Jugador;
            int paso = 30; //La cantidad que se mueve el jugador

            //Aca dice el movimiento según a que lado presionemos
            switch (e.KeyCode)
            {

                case Keys.Left:
                    pctJugador.Left -= paso;
                    break;
                case Keys.Right:
                    pctJugador.Left += paso;
                    break;
            }
        }
        public List<PictureBox> ListaDisparo = new List<PictureBox>(); // Almacena los disparos

        void Disparo(PictureBox Jugador, frmJuego frmJuego)  //Accion de disparar. (movimiento de imagen y creacion de disparo)
        {
            PictureBox pctDisparo = new PictureBox(); //Objeto por lo que voy a trabajar, se instancia en memoria.
            pctDisparo.Image = Image.FromFile(@"C:\Users\win 10\source\repos\pryJuego\Fotos\Disparo.png");
            pctDisparo.Size = new Size(30, 30); //Tamaño del disparo
            pctDisparo.Location = new Point(Jugador.Location.X + 40, 370); //Punto de partida del disparo
            frmJuego.Controls.Add(pctDisparo);
            pctDisparo.SizeMode = PictureBoxSizeMode.StretchImage; //Para que no se deforme
            pctDisparo.BringToFront(); //Para que no le eclipsen otran imagenes

            ListaDisparo.Add(pctDisparo);
            Timer.Start();

        }
        public void Disparar(KeyEventArgs e, PictureBox Jugador, frmJuego frmJuego) //Tenemos que especificar al jugador.
        {
            switch (e.KeyCode)
            {
                case Keys.Space: //Al apretar espacio
                    Disparo(Jugador, frmJuego); //Dispara
                    break;
            }

        }
        public void Timer_Tick(object sender, EventArgs e) //Aca declaramos los tick del timer y el movimiento del disparo
        {
            foreach (var Disparo in ListaDisparo.ToList())
            {
                Disparo.Top -= 10; //Sube
                if (Disparo.Top <= 0) //Si llega arriba del formulario
                {
                    ListaDisparo.Remove(Disparo); //Borra
                    if (Disparo.Parent != null)
                    {
                        Disparo.Parent.Controls.Remove(Disparo); 
                    }
                    Disparo.Dispose(); //Libera los recursos del componente
                }
            }

        }
    }
}