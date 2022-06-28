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
    public partial class MarkForm : Form
    {
      

        public bool Adding { get; set; } = true;

        public MarkForm()
        {
            InitializeComponent();
            readJson();
        }

        private void readJson()
        {

            var markList = new List<Modelo.Color>();
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json"))
            {

                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json", Encoding.UTF8);
                markList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Color>>(colorsInJson);
                dgvRECORDS.DataSource = markList;

                IDbar.Text = (markList.Count + 1).ToString();
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
                var markList = new List<Modelo.Mark>();
                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json"))
                {
                    var marksInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json", Encoding.UTF8);
                    markList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Mark>>(marksInJson);

                }

                var mark = new Modelo.Mark();
                if (Adding == true)
                {
                    mark = new Modelo.Mark
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
                    mark = markList.FirstOrDefault(x => x.ID == ID);
                    if (mark != null)
                    {
                        markList.Remove(mark);
                        mark.Name = NOMBREbar.Text;
                        mark.Visible = chkVISIBLE.Checked;
                        mark.ModifiedDate = DateTime.Now;

                    }

                }

                markList.Add(mark);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(markList);

                StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json", false, Encoding.UTF8);
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

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta seguro de que quiere eliminar la fila?", "DS II", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                var markList = new List<Modelo.Mark>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json"))
                {
                    var marksInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json", Encoding.UTF8);
                    markList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Modelo.Mark>>(marksInJson);

                    var ID = Convert.ToInt32(dgvRECORDS.CurrentRow.Cells["ID"].Value);
                    var mark = markList.FirstOrDefault(x => x.ID == ID);
                    if (mark != null)
                    {
                        markList.Remove(mark);

                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(markList);

                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\mark.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        readJson();

                    }

                }
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

        
    }
}
