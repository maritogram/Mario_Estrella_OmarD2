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
    public partial class ColorForm : Form
    {

        public bool Adding { get; set; } = true;

        public ColorForm()
        {
            InitializeComponent();

            readJson();
        }
       
        private void readJson()
        {

            var colorList = new List<Modelo.Color>();
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
            {

                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Color>>(colorsInJson);
                dgvRECORDS.DataSource = colorList;

                IDbar.Text = (colorList.Count + 1).ToString();
            }
            else
            {
                IDbar.Text = "1";
            }
        }

        private void SaveJson()
        {

            try
            {
                var colorList = new List<Modelo.Color>();
                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
                {
                    var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                    colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Color>>(colorsInJson);

                }

                var color = new Modelo.Color();
                if (Adding == true)
                {
                    color = new Modelo.Color
                    {
                        ID = int.Parse(IDbar.Text),
                        Name = NOMBREbar.Text,
                        Visible = chkVISIBLE.Checked,
                        CreatedDate = DateTime.Now
                    };

                }
                else
                {
                    var ID = Convert.ToInt32(IDbar.Text);
                    color = colorList.FirstOrDefault(x=> x.ID == ID);
                    if (color != null)
                    {
                        colorList.Remove(color);
                        color.Name = NOMBREbar.Text;
                        color.Visible = chkVISIBLE.Checked;
                        color.ModifiedDate = DateTime.Now;

                    }

                }

                colorList.Add(color);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(colorList);

                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("El color fue agregado con exito.");

                clearFields();
                readJson();

            }
            catch (Exception ex)
            {

                throw;
            }


        }

       
        private void clearFields()
        {
            Adding = true;
            IDbar.Text = String.Empty;
            NOMBREbar.Text = String.Empty;
            chkVISIBLE.Checked = false;
        }


        private void GUARDARbtn_Click(object sender, EventArgs e)
        {
            SaveJson();
        }


        private void CANCELARbtn_Click(object sender, EventArgs e)
        {
            clearFields();
            readJson();
        }

        private void dgvRECORDS_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvRECORDS_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvRECORDS.Rows[e.RowIndex].Selected = true;
                var rl = e.RowIndex;
                dgvRECORDS.CurrentCell = dgvRECORDS.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(dgvRECORDS, e.Location);
                contextMenuStrip1.Show(Cursor.Position);    


            }
        }

        private void modificarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (dgvRECORDS.SelectedRows.Count != 0)
            {
                IDbar.Text = dgvRECORDS.CurrentRow.Cells["ID"].Value.ToString();
                NOMBREbar.Text = dgvRECORDS.CurrentRow.Cells["Name"].Value.ToString();
                chkVISIBLE.Checked = (bool)dgvRECORDS.CurrentRow.Cells["Visible"].Value;
                Adding = false;


            }
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Esta seguro de que quiere eliminar la fila?", "DS II", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                var colorList = new List<Modelo.Color>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
                {
                    var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                    colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Color>>(colorsInJson);

                    var ID = Convert.ToInt32(dgvRECORDS.CurrentRow.Cells["ID"].Value);
                    var color = colorList.FirstOrDefault(x => x.ID == ID);
                    if (color != null)
                    {
                        colorList.Remove(color);

                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(colorList);

                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        readJson();

                    }

                }
            }

        }
    }
}
