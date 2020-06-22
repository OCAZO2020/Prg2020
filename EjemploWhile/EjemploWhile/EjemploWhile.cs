using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWhile
{
    public partial class EjemploWhile : Form
    {
        public EjemploWhile()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void bt_click_Click(object sender, EventArgs e)
        {
            int AnchoForm = this.Width;
            int anchoLabel = lbl.Width;
            int anchoBorde = 20;
            int x = 0;
            int paso = 1;

           
            //for(int x = 0;x < AnchoForm - anchoLabel - anchoBorde; x++ )
            //{
            //    lbl.Left = x;
            //}

            while (x < AnchoForm - anchoLabel - anchoBorde)
            {
                lbl.Left = x;
                x = x + paso;
            }


        }

        private void btDerecha_Click(object sender, EventArgs e)
        {
            int AnchoForm = this.Width;
            int anchoLabel = lbl2.Width;
            int anchoBorde = 20;
            //int x = 0;
            int paso = 1;

            //Tarea
            int lblUbicacion = lbl2.Location.X;

            for (int x = lblUbicacion; x >= 0; x--)
            {
                lbl2.Left = x;
            }
        }
    }
}
