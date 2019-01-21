namespace Entrepreneur_App
{
    partial class HelpForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.helpLabel = new System.Windows.Forms.Label();
            this.materialBtn = new System.Windows.Forms.Button();
            this.laborCostBtn = new System.Windows.Forms.Button();
            this.priceBtn = new System.Windows.Forms.Button();
            this.developmentTimeBtn = new System.Windows.Forms.Button();
            this.slowGrowthBtn = new System.Windows.Forms.Button();
            this.intermediateGrowthBtn = new System.Windows.Forms.Button();
            this.rapidGrowthBtn = new System.Windows.Forms.Button();
            this.curveLaborBtn = new System.Windows.Forms.Button();
            this.curveMaterialBtn = new System.Windows.Forms.Button();
            this.helpTextLabel = new System.Windows.Forms.Label();
            this.helpDGV = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessimistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Optimistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.helpDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(364, 19);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(326, 33);
            this.helpLabel.TabIndex = 0;
            this.helpLabel.Text = "Help! Choose wisely...";
            // 
            // materialBtn
            // 
            this.materialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialBtn.Location = new System.Drawing.Point(25, 88);
            this.materialBtn.Name = "materialBtn";
            this.materialBtn.Size = new System.Drawing.Size(184, 93);
            this.materialBtn.TabIndex = 1;
            this.materialBtn.Text = "Expected Material Costs";
            this.materialBtn.UseVisualStyleBackColor = true;
            this.materialBtn.Click += new System.EventHandler(this.materialBtn_Click);
            // 
            // laborCostBtn
            // 
            this.laborCostBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborCostBtn.Location = new System.Drawing.Point(25, 190);
            this.laborCostBtn.Name = "laborCostBtn";
            this.laborCostBtn.Size = new System.Drawing.Size(184, 93);
            this.laborCostBtn.TabIndex = 2;
            this.laborCostBtn.Text = "Expected unit direct labor costs";
            this.laborCostBtn.UseVisualStyleBackColor = true;
            this.laborCostBtn.Click += new System.EventHandler(this.laborCostBtn_Click);
            // 
            // priceBtn
            // 
            this.priceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceBtn.Location = new System.Drawing.Point(25, 292);
            this.priceBtn.Name = "priceBtn";
            this.priceBtn.Size = new System.Drawing.Size(184, 93);
            this.priceBtn.TabIndex = 3;
            this.priceBtn.Text = "Expected price";
            this.priceBtn.UseVisualStyleBackColor = true;
            this.priceBtn.Click += new System.EventHandler(this.priceBtn_Click);
            // 
            // developmentTimeBtn
            // 
            this.developmentTimeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developmentTimeBtn.Location = new System.Drawing.Point(25, 394);
            this.developmentTimeBtn.Name = "developmentTimeBtn";
            this.developmentTimeBtn.Size = new System.Drawing.Size(184, 93);
            this.developmentTimeBtn.TabIndex = 4;
            this.developmentTimeBtn.Text = "Expected product development time";
            this.developmentTimeBtn.UseVisualStyleBackColor = true;
            this.developmentTimeBtn.Click += new System.EventHandler(this.developmentTimeBtn_Click);
            // 
            // slowGrowthBtn
            // 
            this.slowGrowthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slowGrowthBtn.Location = new System.Drawing.Point(838, 88);
            this.slowGrowthBtn.Name = "slowGrowthBtn";
            this.slowGrowthBtn.Size = new System.Drawing.Size(177, 93);
            this.slowGrowthBtn.TabIndex = 5;
            this.slowGrowthBtn.Text = "Estimated plant and equipment investment for slow initial growth";
            this.slowGrowthBtn.UseVisualStyleBackColor = true;
            this.slowGrowthBtn.Click += new System.EventHandler(this.slowGrowthBtn_Click);
            // 
            // intermediateGrowthBtn
            // 
            this.intermediateGrowthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intermediateGrowthBtn.Location = new System.Drawing.Point(838, 189);
            this.intermediateGrowthBtn.Name = "intermediateGrowthBtn";
            this.intermediateGrowthBtn.Size = new System.Drawing.Size(177, 113);
            this.intermediateGrowthBtn.TabIndex = 6;
            this.intermediateGrowthBtn.Text = "Estimated plant and equipment investment for intermediate initial growth";
            this.intermediateGrowthBtn.UseVisualStyleBackColor = true;
            this.intermediateGrowthBtn.Click += new System.EventHandler(this.intermediateGrowthBtn_Click);
            // 
            // rapidGrowthBtn
            // 
            this.rapidGrowthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rapidGrowthBtn.Location = new System.Drawing.Point(838, 310);
            this.rapidGrowthBtn.Name = "rapidGrowthBtn";
            this.rapidGrowthBtn.Size = new System.Drawing.Size(177, 93);
            this.rapidGrowthBtn.TabIndex = 7;
            this.rapidGrowthBtn.Text = "Estimated plant and equipment investment for rapid initial growth";
            this.rapidGrowthBtn.UseVisualStyleBackColor = true;
            this.rapidGrowthBtn.Click += new System.EventHandler(this.rapidGrowthBtn_Click);
            // 
            // curveLaborBtn
            // 
            this.curveLaborBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveLaborBtn.Location = new System.Drawing.Point(838, 411);
            this.curveLaborBtn.Name = "curveLaborBtn";
            this.curveLaborBtn.Size = new System.Drawing.Size(177, 93);
            this.curveLaborBtn.TabIndex = 8;
            this.curveLaborBtn.Text = "Expected learning curve coefficient for labor costs";
            this.curveLaborBtn.UseVisualStyleBackColor = true;
            this.curveLaborBtn.Click += new System.EventHandler(this.curveLaborBtn_Click);
            // 
            // curveMaterialBtn
            // 
            this.curveMaterialBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curveMaterialBtn.Location = new System.Drawing.Point(25, 496);
            this.curveMaterialBtn.Name = "curveMaterialBtn";
            this.curveMaterialBtn.Size = new System.Drawing.Size(184, 85);
            this.curveMaterialBtn.TabIndex = 9;
            this.curveMaterialBtn.Text = "Expected learning curve coefficient for material costs";
            this.curveMaterialBtn.UseVisualStyleBackColor = true;
            this.curveMaterialBtn.Click += new System.EventHandler(this.curveMaterialBtn_Click);
            // 
            // helpTextLabel
            // 
            this.helpTextLabel.AutoEllipsis = true;
            this.helpTextLabel.AutoSize = true;
            this.helpTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTextLabel.Location = new System.Drawing.Point(237, 97);
            this.helpTextLabel.Name = "helpTextLabel";
            this.helpTextLabel.Size = new System.Drawing.Size(0, 20);
            this.helpTextLabel.TabIndex = 10;
            // 
            // helpDGV
            // 
            this.helpDGV.AllowUserToAddRows = false;
            this.helpDGV.AllowUserToDeleteRows = false;
            this.helpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.helpDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.helpDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.helpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.helpDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.Expected,
            this.Pessimistic,
            this.Optimistic});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.helpDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.helpDGV.Location = new System.Drawing.Point(215, 88);
            this.helpDGV.Name = "helpDGV";
            this.helpDGV.ReadOnly = true;
            this.helpDGV.RowHeadersVisible = false;
            this.helpDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.helpDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.helpDGV.Size = new System.Drawing.Size(617, 606);
            this.helpDGV.TabIndex = 11;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Expected
            // 
            this.Expected.HeaderText = "Expected";
            this.Expected.Name = "Expected";
            this.Expected.ReadOnly = true;
            // 
            // Pessimistic
            // 
            this.Pessimistic.HeaderText = "Pessimistic";
            this.Pessimistic.Name = "Pessimistic";
            this.Pessimistic.ReadOnly = true;
            // 
            // Optimistic
            // 
            this.Optimistic.HeaderText = "Optimistic";
            this.Optimistic.Name = "Optimistic";
            this.Optimistic.ReadOnly = true;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 706);
            this.Controls.Add(this.helpDGV);
            this.Controls.Add(this.helpTextLabel);
            this.Controls.Add(this.curveMaterialBtn);
            this.Controls.Add(this.curveLaborBtn);
            this.Controls.Add(this.rapidGrowthBtn);
            this.Controls.Add(this.intermediateGrowthBtn);
            this.Controls.Add(this.slowGrowthBtn);
            this.Controls.Add(this.developmentTimeBtn);
            this.Controls.Add(this.priceBtn);
            this.Controls.Add(this.laborCostBtn);
            this.Controls.Add(this.materialBtn);
            this.Controls.Add(this.helpLabel);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            ((System.ComponentModel.ISupportInitialize)(this.helpDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Button materialBtn;
        private System.Windows.Forms.Button laborCostBtn;
        private System.Windows.Forms.Button priceBtn;
        private System.Windows.Forms.Button developmentTimeBtn;
        private System.Windows.Forms.Button slowGrowthBtn;
        private System.Windows.Forms.Button intermediateGrowthBtn;
        private System.Windows.Forms.Button rapidGrowthBtn;
        private System.Windows.Forms.Button curveLaborBtn;
        private System.Windows.Forms.Button curveMaterialBtn;
        private System.Windows.Forms.Label helpTextLabel;
        private System.Windows.Forms.DataGridView helpDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessimistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Optimistic;
    }
}