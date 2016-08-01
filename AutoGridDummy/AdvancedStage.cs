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
    public partial class AdvancedStage : Form
    {
        public AdvancedStage(AutoGrid_KANDA.AdvancedWell ADwell, int RowIdx)
        {
            InitializeComponent();
            this.CenterToScreen();

            string str = "";
            for (int i = 0; i < ADwell.ListOfNumStages[RowIdx]; i++)
            {
                this.dataGridView1.Rows.Add(str, str, str, str, str);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = System.Convert.ToString(dataGridView1.Rows.Count); 
            }           
        }
    }
}
