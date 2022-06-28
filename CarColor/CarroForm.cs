using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarColor
{
    public partial class CarroForm : Form
    {
        public CarroForm()
        {
            InitializeComponent();

            //lblMSGS.Text = AppDomain.CurrentDomain.BaseDirectory;
            getColors();
            getMarks();

        }

        private void GUARDARbtn_Click(object sender, EventArgs e)
        {

        }

        private void CANCELARbtn_Click(object sender, EventArgs e)
        {
            getColors();
            getMarks();
        }

        private void BotonFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnCOLORFORM_Click(object sender, EventArgs e)
        {
            var frm = new ColorForm();
            frm.Show();
        }

        private void btnMARCAFORM_Click(object sender, EventArgs e)
        {
            var frm = new MarkForm();
            frm.ShowDialog();
        }

        private void btnMODELOFORM_Click(object sender, EventArgs e)
        {
            var frm = new ModelForm();
            frm.Show();
        }

        private void CarroForm_Load(object sender, EventArgs e)
        {

        }


        private void getMarks()
        {

            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json"))
            {

                var marksInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json", Encoding.UTF8);
                var markList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Mark>>(marksInJson);

                cbMARCA.DataSource = markList.Where(x => x.Visible).ToList();
                cbMARCA.DisplayMember = "Name";
                cbMARCA.ValueMember = "ID";

            }

        }


        private void getColors()
        {

            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
            {

                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                var colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Color>>(colorsInJson);

                cbCOLOR.DataSource = colorList.Where(x=> x.Visible).ToList();
                cbCOLOR.DisplayMember = "Name";
                cbCOLOR.ValueMember = "ID";
                
            }
           
        }

       
    }
}
