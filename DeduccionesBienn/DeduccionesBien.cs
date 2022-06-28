using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeduccionesBienn
{
    public partial class DeduccionesBien : Form
    {
        public DeduccionesBien()
        {
            InitializeComponent();
        }

            
        private void Calcular_Click(object sender, EventArgs e)
        {
            double Sueldo = double.Parse(SueldoBruto.Text);
            

            SFSx(Sueldo);
            AFPx(Sueldo);
            ISRx(Sueldo);

            double SueldoNetox = Sueldo - (double.Parse(SFS.Text) + double.Parse(AFP.Text) + double.Parse(ISR.Text));

            SueldoNeto.Text = Convert.ToString(SueldoNetox);

        }
    
        private void SFSx(double sueldo)
        {


           double SFS_Deduccion = sueldo * 0.0304;

            if (SFS_Deduccion > 4742.40)
            {
                SFS.Text = "4742.40";
            } else
            SFS.Text = Convert.ToString(SFS_Deduccion);

           
        }

        private void AFPx(double sueldo)
        {

           double AFP_Deduccion = sueldo * 0.0287;

            if (AFP_Deduccion > 8954.40)
            {
               AFP.Text = "8954.40";

            } else 
            AFP.Text = Convert.ToString(AFP_Deduccion);
        }

        private void ISRx(double sueldo)
        {

            double anualSB = (sueldo - double.Parse(AFP.Text) - double.Parse(SFS.Text)) * 12;


            if (anualSB <= 416220)
            {
                ISR.Text = "0";

            } else if(anualSB <= 624329)
            {
                double restante = anualSB - 416220;
                ISR.Text = Convert.ToString((restante * 0.15) / 12);

            } else if (anualSB <= 867123)
            {
                double restante = anualSB - 624329;
                ISR.Text = Convert.ToString(((restante * 0.20) + 31216) / 12);

            } else if (anualSB > 867123){

                double restante = anualSB - 867123;
                ISR.Text = Convert.ToString(((restante * 0.25) + 79776) / 12);
            }

            //done ya
        }

      
    }
}
