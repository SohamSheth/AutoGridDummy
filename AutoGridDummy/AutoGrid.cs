using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AutoGrid_KANDA
{
    public partial class AutoGrid : Form
    {
        public List<double> ListOfNumWells = new List<double>();
        public List<CaseClass> CaseObjects = new List<CaseClass>();
        public List<AdvancedWell> WellFormsList = new List<AdvancedWell>();
        AdvancedWell ADWell;

        public AutoGrid(int do_nothing) { } //this ctor is called from Advanced Well and does NOTHING! 
        public AutoGrid()
        {
            InitializeComponent();
            this.CenterToScreen();
            string str = "";
            Button but = new Button();
            but.Click += new EventHandler(dataGridView1_CellContentClick);

            this.dataGridView1.Rows.Add(str, str, but, str, str, str, str, str, str, str);
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = System.Convert.ToString(dataGridView1.Rows.Count);
            ListOfNumWells.Add(0.0);
            CaseObjects.Add(new CaseClass(dataGridView1.Rows.Count));
            CaseObjects[0].IsFirstOpen = true;

            ADWell = new AdvancedWell(this, 0);
            WellFormsList.Add(ADWell);
        }

        private void Addcase_Click(object sender, EventArgs e)
        {
            string str = "";
            Button but = new Button();
            but.Click += new EventHandler(dataGridView1_CellContentClick);

            this.dataGridView1.Rows.Add(str, str, but, str, str, str, str, str, str, str);
            dataGridView1.Rows[dataGridView1.Rows.Count-1].Cells[0].Value = System.Convert.ToString(dataGridView1.Rows.Count);
            ListOfNumWells.Add(0.0);

            CaseObjects.Add(new CaseClass(dataGridView1.Rows.Count));
            CaseObjects[dataGridView1.Rows.Count-1].IsFirstOpen = true;

            ADWell = new AdvancedWell(this, dataGridView1.CurrentCell.RowIndex);
            WellFormsList.Add(ADWell);
        }

        private void DeleteCase_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                ListOfNumWells.RemoveAt(dataGridView1.Rows.Count-1);
                this.CaseObjects.RemoveAt(dataGridView1.Rows.Count - 1);
                this.WellFormsList.RemoveAt(dataGridView1.Rows.Count - 1);
                this.dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            } 
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            DataGridView dgvr = (DataGridView)sender;
            DataGridViewCellEventArgs eCell = (DataGridViewCellEventArgs)e;

            if (eCell.RowIndex >= 0)
            {
                if (dgvr.CurrentCell.ColumnIndex.Equals(2))
                {
                    if (CaseObjects[dgvr.CurrentCell.RowIndex].IsFirstOpen == true)
                    {
                        CaseObjects[dgvr.CurrentCell.RowIndex].SetWellDefault(GridProps); //Fills the well form with default values
                        CaseObjects[dgvr.CurrentCell.RowIndex].IsFirstOpen = false;

                        ADWell = new AdvancedWell(this, dgvr.CurrentCell.RowIndex);
                        WellFormsList[dgvr.CurrentCell.RowIndex] = ADWell;
                        ADWell.Owner = this.FindForm();
                        ADWell.ShowDialog();
                    }
                    else
                    {
                        WellFormsList[dgvr.CurrentCell.RowIndex].StartPosition = FormStartPosition.CenterScreen;
                        WellFormsList[dgvr.CurrentCell.RowIndex].ShowDialog();
                    }

                    enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[4], false);
                    enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[5], false);
                    enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[6], false);
                    enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[7], false);
                    enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[8], false);

                }
                else if (dgvr.CurrentCell.ColumnIndex.Equals(10))
                {
                    const string message =
                                    "Are you sure that you want to reset the case?";
                    const string caption = "Resetting case";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[4], true);
                        enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[5], true);
                        enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[6], true);
                        enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[7], true);
                        enableCell(dgvr.Rows[dgvr.CurrentCell.RowIndex].Cells[8], true);
                    }
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentCell.Value != String.Empty)
            {
                if (e.ColumnIndex == 1)
                {
                    if (ListOfNumWells[e.RowIndex] != System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true;
                    }
                    ListOfNumWells[e.RowIndex] = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    CaseObjects[e.RowIndex].NumerOfWells = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                    CaseObjects[e.RowIndex].InitializeWellObjects();
                }
                if (e.ColumnIndex == 3)
                {
                    if (CaseObjects[e.RowIndex].WellDirection != System.Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true; 
                    }
                    CaseObjects[e.RowIndex].WellDirection = System.Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 4)
                {
                    if (CaseObjects[e.RowIndex].WellLength != System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true; 
                    }
                    CaseObjects[e.RowIndex].WellLength = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 5)
                {
                    if (CaseObjects[e.RowIndex].NumberOfStagesPerWell != System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true;
                    }
                    CaseObjects[e.RowIndex].NumberOfStagesPerWell = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 6)
                {
                    if (CaseObjects[e.RowIndex].NumberOfPerfClustersPerStage != System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true;
                    }
                    CaseObjects[e.RowIndex].NumberOfPerfClustersPerStage = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 7)
                {
                    if (CaseObjects[e.RowIndex].SuccessRateOfPerforations != System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true;
                    }
                    CaseObjects[e.RowIndex].SuccessRateOfPerforations = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 8)
                {
                    if (CaseObjects[e.RowIndex].FractureHalfLength != System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true;
                    }
                    CaseObjects[e.RowIndex].FractureHalfLength = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 9)
                {
                    if (CaseObjects[e.RowIndex].PerforationTolerance != System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value))
                    {
                        CaseObjects[dataGridView1.CurrentCell.RowIndex].IsFirstOpen = true;
                    }
                    CaseObjects[e.RowIndex].PerforationTolerance = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
            }
        }

        private void enableCell(DataGridViewCell DataCell, bool enabled)
        {
            DataCell.ReadOnly = !enabled;
            if (enabled)
            {
                DataCell.Style.BackColor = DataCell.OwningColumn.DefaultCellStyle.BackColor;
                DataCell.Style.ForeColor = DataCell.OwningColumn.DefaultCellStyle.ForeColor;
            }
            else
            {
                DataCell.Style.BackColor = Color.LightGray;
                DataCell.Style.ForeColor = Color.DarkGray;
            }
        }

        GridPropsClass GridProps = new GridPropsClass();
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                for (int i = 0; i < CaseObjects.Count; i++)
                {
                    CaseObjects[i].IsFirstOpen = true;
                }
                GridProps.Lx = System.Convert.ToDouble(textBox1.Text);
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox2.Text) && GridProps.Ly != System.Convert.ToDouble(textBox2.Text))
            {
                for (int i = 0; i < CaseObjects.Count; i++)
                {
                    CaseObjects[i].IsFirstOpen = true;
                }
                GridProps.Ly = System.Convert.ToDouble(textBox2.Text);
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox3.Text) && GridProps.Nx != System.Convert.ToInt32(textBox3.Text))
            {
                GridProps.Nx = System.Convert.ToInt32(textBox3.Text);
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox4.Text) && GridProps.Ny != System.Convert.ToInt32(textBox4.Text))
            {
                GridProps.Ny = System.Convert.ToInt32(textBox4.Text);
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox5.Text) && GridProps.MinThick != System.Convert.ToDouble(textBox5.Text))
            {
                GridProps.MinThick = System.Convert.ToDouble(textBox5.Text);
            }
        }

    }
}
