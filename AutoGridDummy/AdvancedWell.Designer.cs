namespace AutoGrid_KANDA
{
    partial class AdvancedWell
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Well = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvancedStage = new System.Windows.Forms.DataGridViewButtonColumn();
            this.PerfClus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HalfLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Well,
            this.x,
            this.Y,
            this.Length,
            this.Stages,
            this.AdvancedStage,
            this.PerfClus,
            this.Success,
            this.HalfLength});
            this.dataGridView1.Location = new System.Drawing.Point(50, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(703, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Well
            // 
            this.Well.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Well.HeaderText = "Well";
            this.Well.Name = "Well";
            this.Well.Width = 53;
            // 
            // x
            // 
            this.x.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.x.HeaderText = "Well X loc.";
            this.x.Name = "x";
            this.x.Width = 83;
            // 
            // Y
            // 
            this.Y.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Y.HeaderText = "Well Y loc.";
            this.Y.Name = "Y";
            this.Y.Width = 83;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.Width = 65;
            // 
            // Stages
            // 
            this.Stages.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Stages.HeaderText = "Nos. Stages";
            this.Stages.Name = "Stages";
            this.Stages.Width = 90;
            // 
            // AdvancedStage
            // 
            this.AdvancedStage.HeaderText = "";
            this.AdvancedStage.Name = "AdvancedStage";
            this.AdvancedStage.Text = "+";
            this.AdvancedStage.UseColumnTextForButtonValue = true;
            this.AdvancedStage.Width = 25;
            // 
            // PerfClus
            // 
            this.PerfClus.HeaderText = "Perf. Clus. ";
            this.PerfClus.Name = "PerfClus";
            // 
            // Success
            // 
            this.Success.HeaderText = "Success (%)";
            this.Success.Name = "Success";
            // 
            // HalfLength
            // 
            this.HalfLength.HeaderText = "HL";
            this.HalfLength.Name = "HalfLength";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(678, 322);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedWell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 544);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdvancedWell";
            this.Text = "AdvancedWell";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Well;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stages;
        private System.Windows.Forms.DataGridViewButtonColumn AdvancedStage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfClus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Success;
        private System.Windows.Forms.DataGridViewTextBoxColumn HalfLength;
        private System.Windows.Forms.Button ApplyButton;
    }
}