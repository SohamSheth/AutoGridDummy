using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGrid_KANDA
{
    
    public partial class AdvancedWell : Form
    {
        public List<double> ListOfNumStages = new List<double>();
        private int RowIndex;
        AutoGrid mAutoGrid = new AutoGrid(0);
        public AdvancedWell(AutoGrid_KANDA.AutoGrid AutoGrid, int RowIdx)
        {         
            InitializeComponent();
            this.CenterToScreen();
            RowIndex = RowIdx;
            mAutoGrid = AutoGrid;
            string str = "";
            for (int i = 0; i < AutoGrid.ListOfNumWells[RowIdx]; i++)
            {
                Button but = new Button();
                but.Click += new EventHandler(dataGridView1_CellContentClick);
                this.dataGridView1.Rows.Add(str, str, str, str, str, but, str, str, str);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = System.Convert.ToString(dataGridView1.Rows.Count);
                ListOfNumStages.Add(0.0);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].WellStartingPointX;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].WellStartingPointY;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].WellLength;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].NumberOfStagesPerWell;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].NumberOfPerfClustersPerStage;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[7].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].SuccessRateOfPerforations;
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[8].Value = AutoGrid.CaseObjects[RowIdx].WellObjects[i].FractureHalfLength;
            }           
        }

        AdvancedStage ADStage;
        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            DataGridView dgvr = (DataGridView)sender;
            if (dgvr.CurrentCell.ColumnIndex.Equals(5))
            {
                ADStage = new AdvancedStage(this, dgvr.CurrentCell.RowIndex);
                ADStage.Owner = this.FindForm();
                ADStage.ShowDialog();
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.Value != String.Empty)
            {
                if (e.ColumnIndex == 1)
                {
                    mAutoGrid.CaseObjects[RowIndex].WellObjects[e.RowIndex].WellStartingPointX = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 2)
                {
                    mAutoGrid.CaseObjects[RowIndex].WellObjects[e.RowIndex].WellStartingPointY = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 3)
                {
                    mAutoGrid.CaseObjects[RowIndex].WellObjects[e.RowIndex].WellLength = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 4)
                {
                    ListOfNumStages[e.RowIndex] = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 6)
                {
                    mAutoGrid.CaseObjects[RowIndex].WellObjects[e.RowIndex].NumberOfPerfClustersPerStage = System.Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 7)
                {
                    mAutoGrid.CaseObjects[RowIndex].WellObjects[e.RowIndex].SuccessRateOfPerforations = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
                if (e.ColumnIndex == 8)
                {
                    mAutoGrid.CaseObjects[RowIndex].WellObjects[e.RowIndex].FractureHalfLength = System.Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                }
            }
        }
    }
}
