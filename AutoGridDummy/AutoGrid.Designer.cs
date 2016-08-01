namespace AutoGrid_KANDA
{
    partial class AutoGrid
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
            this.Auto_Grid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Case = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wells = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advancedWellOptions = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Direction = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perforations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Success = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HalfLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reset = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Addcase = new System.Windows.Forms.Button();
            this.DeleteCase = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ResLX = new System.Windows.Forms.Label();
            this.ResLY = new System.Windows.Forms.Label();
            this.ResNX = new System.Windows.Forms.Label();
            this.ResNY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CaseDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Auto_Grid
            // 
            this.Auto_Grid.AutoSize = true;
            this.Auto_Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Auto_Grid.Location = new System.Drawing.Point(46, 29);
            this.Auto_Grid.Name = "Auto_Grid";
            this.Auto_Grid.Size = new System.Drawing.Size(115, 29);
            this.Auto_Grid.TabIndex = 0;
            this.Auto_Grid.Text = "AutoGrid";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Case,
            this.Wells,
            this.advancedWellOptions,
            this.Direction,
            this.Length,
            this.Stages,
            this.Perforations,
            this.Success,
            this.HalfLength,
            this.Tol,
            this.Reset});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(45, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 251);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Case
            // 
            this.Case.HeaderText = "Case";
            this.Case.Name = "Case";
            this.Case.ReadOnly = true;
            this.Case.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Wells
            // 
            this.Wells.HeaderText = "Wells";
            this.Wells.Name = "Wells";
            // 
            // advancedWellOptions
            // 
            this.advancedWellOptions.HeaderText = "";
            this.advancedWellOptions.Name = "advancedWellOptions";
            this.advancedWellOptions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.advancedWellOptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.advancedWellOptions.Text = " + ";
            this.advancedWellOptions.UseColumnTextForButtonValue = true;
            this.advancedWellOptions.Width = 25;
            // 
            // Direction
            // 
            this.Direction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Direction.HeaderText = "Well Dir.";
            this.Direction.Items.AddRange(new object[] {
            "X",
            "Y"});
            this.Direction.Name = "Direction";
            this.Direction.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Direction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Direction.Width = 86;
            // 
            // Length
            // 
            this.Length.HeaderText = "Well Len.";
            this.Length.Name = "Length";
            // 
            // Stages
            // 
            this.Stages.HeaderText = "Stages";
            this.Stages.Name = "Stages";
            // 
            // Perforations
            // 
            this.Perforations.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Perforations.HeaderText = "Perf. Clus.";
            this.Perforations.Name = "Perforations";
            this.Perforations.Width = 98;
            // 
            // Success
            // 
            this.Success.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Success.HeaderText = "Success (%)";
            this.Success.Name = "Success";
            this.Success.Width = 112;
            // 
            // HalfLength
            // 
            this.HalfLength.HeaderText = "HL";
            this.HalfLength.Name = "HalfLength";
            // 
            // Tol
            // 
            this.Tol.HeaderText = "Perf. TOL";
            this.Tol.Name = "Tol";
            // 
            // Reset
            // 
            this.Reset.HeaderText = "";
            this.Reset.Name = "Reset";
            this.Reset.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Reset.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Reset.Text = "Reset Case";
            this.Reset.UseColumnTextForButtonValue = true;
            this.Reset.Width = 106;
            // 
            // Addcase
            // 
            this.Addcase.Location = new System.Drawing.Point(47, 544);
            this.Addcase.Name = "Addcase";
            this.Addcase.Size = new System.Drawing.Size(75, 34);
            this.Addcase.TabIndex = 3;
            this.Addcase.Text = "Add case";
            this.Addcase.UseVisualStyleBackColor = true;
            this.Addcase.Click += new System.EventHandler(this.Addcase_Click);
            // 
            // DeleteCase
            // 
            this.DeleteCase.Location = new System.Drawing.Point(129, 544);
            this.DeleteCase.Name = "DeleteCase";
            this.DeleteCase.Size = new System.Drawing.Size(75, 34);
            this.DeleteCase.TabIndex = 4;
            this.DeleteCase.Text = "Delete";
            this.DeleteCase.UseVisualStyleBackColor = true;
            this.DeleteCase.Click += new System.EventHandler(this.DeleteCase_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(353, 152);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(353, 181);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 8;
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // ResLX
            // 
            this.ResLX.AutoSize = true;
            this.ResLX.Location = new System.Drawing.Point(89, 152);
            this.ResLX.Name = "ResLX";
            this.ResLX.Size = new System.Drawing.Size(34, 17);
            this.ResLX.TabIndex = 9;
            this.ResLX.Text = "Lx : ";
            // 
            // ResLY
            // 
            this.ResLY.AutoSize = true;
            this.ResLY.Location = new System.Drawing.Point(89, 181);
            this.ResLY.Name = "ResLY";
            this.ResLY.Size = new System.Drawing.Size(35, 17);
            this.ResLY.TabIndex = 10;
            this.ResLY.Text = "Ly : ";
            // 
            // ResNX
            // 
            this.ResNX.AutoSize = true;
            this.ResNX.Location = new System.Drawing.Point(313, 152);
            this.ResNX.Name = "ResNX";
            this.ResNX.Size = new System.Drawing.Size(36, 17);
            this.ResNX.TabIndex = 11;
            this.ResNX.Text = "Nx : ";
            // 
            // ResNY
            // 
            this.ResNY.AutoSize = true;
            this.ResNY.Location = new System.Drawing.Point(313, 181);
            this.ResNY.Name = "ResNY";
            this.ResNY.Size = new System.Drawing.Size(37, 17);
            this.ResNY.TabIndex = 12;
            this.ResNY.Text = "Ny : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Min. Thick.";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(618, 152);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 13;
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // CaseDescription
            // 
            this.CaseDescription.AutoSize = true;
            this.CaseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaseDescription.Location = new System.Drawing.Point(47, 253);
            this.CaseDescription.Name = "CaseDescription";
            this.CaseDescription.Size = new System.Drawing.Size(135, 18);
            this.CaseDescription.TabIndex = 15;
            this.CaseDescription.Text = "Case description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Grid inputs";
            // 
            // GenerateGrid
            // 
            this.GenerateGrid.Location = new System.Drawing.Point(960, 544);
            this.GenerateGrid.Name = "GenerateGrid";
            this.GenerateGrid.Size = new System.Drawing.Size(116, 34);
            this.GenerateGrid.TabIndex = 18;
            this.GenerateGrid.Text = "Generate grid";
            this.GenerateGrid.UseVisualStyleBackColor = true;
            // 
            // AutoGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 628);
            this.Controls.Add(this.GenerateGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaseDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.ResNY);
            this.Controls.Add(this.ResNX);
            this.Controls.Add(this.ResLY);
            this.Controls.Add(this.ResLX);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteCase);
            this.Controls.Add(this.Addcase);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Auto_Grid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AutoGrid";
            this.Text = "AutoGrid";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Auto_Grid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addcase;
        private System.Windows.Forms.Button DeleteCase;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label ResLX;
        private System.Windows.Forms.Label ResLY;
        private System.Windows.Forms.Label ResNX;
        private System.Windows.Forms.Label ResNY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label CaseDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Case;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wells;
        private System.Windows.Forms.DataGridViewButtonColumn advancedWellOptions;
        private System.Windows.Forms.DataGridViewComboBoxColumn Direction;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stages;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perforations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Success;
        private System.Windows.Forms.DataGridViewTextBoxColumn HalfLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tol;
        private System.Windows.Forms.DataGridViewButtonColumn Reset;
    }
}

