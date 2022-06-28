namespace CarColor
{
    partial class ColorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CANCELARbtn = new System.Windows.Forms.Button();
            this.GUARDARbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NOMBREbar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDbar = new System.Windows.Forms.TextBox();
            this.dgvRECORDS = new System.Windows.Forms.DataGridView();
            this.chkVISIBLE = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRegistroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRECORDS)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CANCELARbtn
            // 
            this.CANCELARbtn.Location = new System.Drawing.Point(236, 167);
            this.CANCELARbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CANCELARbtn.Name = "CANCELARbtn";
            this.CANCELARbtn.Size = new System.Drawing.Size(179, 68);
            this.CANCELARbtn.TabIndex = 39;
            this.CANCELARbtn.Text = "CANCELAR";
            this.CANCELARbtn.UseVisualStyleBackColor = true;
            this.CANCELARbtn.Click += new System.EventHandler(this.CANCELARbtn_Click);
            // 
            // GUARDARbtn
            // 
            this.GUARDARbtn.Location = new System.Drawing.Point(35, 167);
            this.GUARDARbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GUARDARbtn.Name = "GUARDARbtn";
            this.GUARDARbtn.Size = new System.Drawing.Size(179, 68);
            this.GUARDARbtn.TabIndex = 38;
            this.GUARDARbtn.Text = "GUARDAR";
            this.GUARDARbtn.UseVisualStyleBackColor = true;
            this.GUARDARbtn.Click += new System.EventHandler(this.GUARDARbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre";
            // 
            // NOMBREbar
            // 
            this.NOMBREbar.Location = new System.Drawing.Point(168, 79);
            this.NOMBREbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NOMBREbar.Name = "NOMBREbar";
            this.NOMBREbar.Size = new System.Drawing.Size(189, 22);
            this.NOMBREbar.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID";
            // 
            // IDbar
            // 
            this.IDbar.Location = new System.Drawing.Point(168, 47);
            this.IDbar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IDbar.Name = "IDbar";
            this.IDbar.ReadOnly = true;
            this.IDbar.Size = new System.Drawing.Size(189, 22);
            this.IDbar.TabIndex = 22;
            // 
            // dgvRECORDS
            // 
            this.dgvRECORDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRECORDS.Location = new System.Drawing.Point(443, 13);
            this.dgvRECORDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvRECORDS.Name = "dgvRECORDS";
            this.dgvRECORDS.RowHeadersWidth = 51;
            this.dgvRECORDS.Size = new System.Drawing.Size(605, 427);
            this.dgvRECORDS.TabIndex = 40;
            this.dgvRECORDS.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRECORDS_CellMouseUp);
            this.dgvRECORDS.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRECORDS_UserDeletedRow);
            // 
            // chkVISIBLE
            // 
            this.chkVISIBLE.AutoSize = true;
            this.chkVISIBLE.Location = new System.Drawing.Point(80, 123);
            this.chkVISIBLE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkVISIBLE.Name = "chkVISIBLE";
            this.chkVISIBLE.Size = new System.Drawing.Size(131, 20);
            this.chkVISIBLE.TabIndex = 41;
            this.chkVISIBLE.Text = "Visible al publico";
            this.chkVISIBLE.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarRegistroToolStripMenuItem,
            this.modificarRegistroToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // eliminarRegistroToolStripMenuItem
            // 
            this.eliminarRegistroToolStripMenuItem.Name = "eliminarRegistroToolStripMenuItem";
            this.eliminarRegistroToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.eliminarRegistroToolStripMenuItem.Text = "Eliminar Registro";
            this.eliminarRegistroToolStripMenuItem.Click += new System.EventHandler(this.eliminarRegistroToolStripMenuItem_Click);
            // 
            // modificarRegistroToolStripMenuItem
            // 
            this.modificarRegistroToolStripMenuItem.Name = "modificarRegistroToolStripMenuItem";
            this.modificarRegistroToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.modificarRegistroToolStripMenuItem.Text = "Modificar Registro";
            this.modificarRegistroToolStripMenuItem.Click += new System.EventHandler(this.modificarRegistroToolStripMenuItem_Click);
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1061, 450);
            this.Controls.Add(this.chkVISIBLE);
            this.Controls.Add(this.dgvRECORDS);
            this.Controls.Add(this.CANCELARbtn);
            this.Controls.Add(this.GUARDARbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NOMBREbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDbar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "ColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRECORDS)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CANCELARbtn;
        private System.Windows.Forms.Button GUARDARbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NOMBREbar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDbar;
        private System.Windows.Forms.DataGridView dgvRECORDS;
        private System.Windows.Forms.CheckBox chkVISIBLE;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarRegistroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRegistroToolStripMenuItem;
    }
}