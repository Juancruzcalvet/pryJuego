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
        clsNave objNave;
        clsEnemigo objEnemigo;
        public frmJuego()
        {
            InitializeComponent();

            objNave = new clsNave();
            objEnemigo = new clsEnemigo();

            objEnemigo.Spawn(this);

            this.KeyPreview = true; //recibe evento del teclado
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            objNave.Movimiento(e, pictureBox1); //ejecutanddo clase con el objeto creado en el evento tecla
            objNave.Disparar(e , pictureBox1 , this);
        }
    }
}
