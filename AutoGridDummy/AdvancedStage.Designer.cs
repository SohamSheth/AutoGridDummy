namespace AutoGrid_KANDA
{
    partial class AdvancedStage
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
            this.Stage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StageLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PerfClus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HalfLen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApplyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stage,
            this.StageLength,
            this.PerfClus,
            this.Success,
            this.HalfLen});
            this.dataGridView1.Location = new System.Drawing.Point(60, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(503, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // Stage
            // 
            this.Stage.HeaderText = "Stage";
            this.Stage.Name = "Stage";
            // 
            // StageLength
            // 
            this.StageLength.HeaderText = "Length";
            this.StageLength.Name = "StageLength";
            // 
            // PerfClus
            // 
            this.PerfClus.HeaderText = "Perf. Clus.";
            this.PerfClus.Name = "PerfClus";
            // 
            // Success
            // 
            this.Success.HeaderText = "Success (%)";
            this.Success.Name = "Success";
            // 
            // HalfLen
            // 
            this.HalfLen.HeaderText = "HL";
            this.HalfLen.Name = "HalfLen";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(488, 289);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            // 
            // AdvancedStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 426);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdvancedStage";
            this.Text = "AdvancedStage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stage;
        private System.Windows.Forms.DataGridViewTextBoxColumn StageLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn PerfClus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Success;
        private System.Windows.Forms.DataGridViewTextBoxColumn HalfLen;
        private System.Windows.Forms.Button ApplyButton;
    }
}