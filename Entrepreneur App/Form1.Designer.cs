namespace Entrepreneur_App
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oppButton = new System.Windows.Forms.Button();
            this.acceptOppButton = new System.Windows.Forms.Button();
            this.rejectOppButton = new System.Windows.Forms.Button();
            this.explanationTextBox = new System.Windows.Forms.TextBox();
            this.explainLabel = new System.Windows.Forms.Label();
            this.maxCharacterLabel = new System.Windows.Forms.Label();
            this.opportunityDisplay = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            this.pastOpportunityDisplay = new System.Windows.Forms.Label();
            this.pastOpportunityLabel = new System.Windows.Forms.Label();
            this.currentOpportunityLabel = new System.Windows.Forms.Label();
            this.pastDGV = new System.Windows.Forms.DataGridView();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pessimistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Optimistic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.classCodeLabel = new System.Windows.Forms.Label();
            this.classNumberLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.classNumberTextBox = new System.Windows.Forms.TextBox();
            this.classCodeBox = new System.Windows.Forms.ComboBox();
            this.playButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.instrucLabel = new System.Windows.Forms.Label();
            this.describeBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1114, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartBtn});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // restartBtn
            // 
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(144, 22);
            this.restartBtn.Text = "Restart Game";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // oppButton
            // 
            this.oppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oppButton.Location = new System.Drawing.Point(106, 620);
            this.oppButton.Name = "oppButton";
            this.oppButton.Size = new System.Drawing.Size(142, 122);
            this.oppButton.TabIndex = 12;
            this.oppButton.Text = "Show me the opportunity!!";
            this.oppButton.UseVisualStyleBackColor = true;
            this.oppButton.Visible = false;
            this.oppButton.Click += new System.EventHandler(this.oppButton_Click);
            // 
            // acceptOppButton
            // 
            this.acceptOppButton.BackColor = System.Drawing.Color.Lime;
            this.acceptOppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptOppButton.Enabled = false;
            this.acceptOppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acceptOppButton.Location = new System.Drawing.Point(282, 742);
            this.acceptOppButton.Name = "acceptOppButton";
            this.acceptOppButton.Size = new System.Drawing.Size(180, 73);
            this.acceptOppButton.TabIndex = 14;
            this.acceptOppButton.Text = "Accept";
            this.acceptOppButton.UseVisualStyleBackColor = false;
            this.acceptOppButton.Visible = false;
            this.acceptOppButton.Click += new System.EventHandler(this.acceptOppButton_Click);
            // 
            // rejectOppButton
            // 
            this.rejectOppButton.BackColor = System.Drawing.Color.Red;
            this.rejectOppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rejectOppButton.Enabled = false;
            this.rejectOppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rejectOppButton.Location = new System.Drawing.Point(682, 742);
            this.rejectOppButton.Name = "rejectOppButton";
            this.rejectOppButton.Size = new System.Drawing.Size(152, 73);
            this.rejectOppButton.TabIndex = 15;
            this.rejectOppButton.Text = "Reject";
            this.rejectOppButton.UseVisualStyleBackColor = false;
            this.rejectOppButton.Visible = false;
            this.rejectOppButton.Click += new System.EventHandler(this.rejectOppButton_Click);
            // 
            // explanationTextBox
            // 
            this.explanationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationTextBox.Location = new System.Drawing.Point(282, 608);
            this.explanationTextBox.MaxLength = 280;
            this.explanationTextBox.Multiline = true;
            this.explanationTextBox.Name = "explanationTextBox";
            this.explanationTextBox.Size = new System.Drawing.Size(552, 128);
            this.explanationTextBox.TabIndex = 16;
            this.explanationTextBox.Visible = false;
            this.explanationTextBox.TextChanged += new System.EventHandler(this.explanationTextBox_TextChanged);
            // 
            // explainLabel
            // 
            this.explainLabel.AutoSize = true;
            this.explainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explainLabel.Location = new System.Drawing.Point(546, 644);
            this.explainLabel.Name = "explainLabel";
            this.explainLabel.Size = new System.Drawing.Size(184, 20);
            this.explainLabel.TabIndex = 17;
            this.explainLabel.Text = "Describe this opportunity";
            this.explainLabel.Visible = false;
            // 
            // maxCharacterLabel
            // 
            this.maxCharacterLabel.AutoSize = true;
            this.maxCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxCharacterLabel.Location = new System.Drawing.Point(546, 815);
            this.maxCharacterLabel.Name = "maxCharacterLabel";
            this.maxCharacterLabel.Size = new System.Drawing.Size(230, 20);
            this.maxCharacterLabel.TabIndex = 19;
            this.maxCharacterLabel.Text = "Characters left: 280. (Max 280).";
            this.maxCharacterLabel.Visible = false;
            // 
            // opportunityDisplay
            // 
            this.opportunityDisplay.AutoEllipsis = true;
            this.opportunityDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opportunityDisplay.Location = new System.Drawing.Point(51, 96);
            this.opportunityDisplay.Name = "opportunityDisplay";
            this.opportunityDisplay.Size = new System.Drawing.Size(1040, 410);
            this.opportunityDisplay.TabIndex = 24;
            this.opportunityDisplay.Text = "Click on \"Show me the opportunity!!\" button to begin!";
            this.opportunityDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.opportunityDisplay.Visible = false;
            // 
            // helpBtn
            // 
            this.helpBtn.Enabled = false;
            this.helpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(339, 529);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(152, 73);
            this.helpBtn.TabIndex = 25;
            this.helpBtn.Text = "Help! I need more info!";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Visible = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // pastOpportunityDisplay
            // 
            this.pastOpportunityDisplay.AutoEllipsis = true;
            this.pastOpportunityDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.pastOpportunityDisplay.Location = new System.Drawing.Point(12, 70);
            this.pastOpportunityDisplay.Name = "pastOpportunityDisplay";
            this.pastOpportunityDisplay.Size = new System.Drawing.Size(513, 436);
            this.pastOpportunityDisplay.TabIndex = 26;
            this.pastOpportunityDisplay.Text = "Click on \"Show me the opportunity!!\" button to begin!";
            this.pastOpportunityDisplay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pastOpportunityDisplay.Visible = false;
            // 
            // pastOpportunityLabel
            // 
            this.pastOpportunityLabel.AutoSize = true;
            this.pastOpportunityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastOpportunityLabel.Location = new System.Drawing.Point(191, 33);
            this.pastOpportunityLabel.Name = "pastOpportunityLabel";
            this.pastOpportunityLabel.Size = new System.Drawing.Size(143, 20);
            this.pastOpportunityLabel.TabIndex = 27;
            this.pastOpportunityLabel.Text = "Past Opportunity";
            this.pastOpportunityLabel.Visible = false;
            // 
            // currentOpportunityLabel
            // 
            this.currentOpportunityLabel.AutoSize = true;
            this.currentOpportunityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentOpportunityLabel.Location = new System.Drawing.Point(459, 28);
            this.currentOpportunityLabel.Name = "currentOpportunityLabel";
            this.currentOpportunityLabel.Size = new System.Drawing.Size(167, 20);
            this.currentOpportunityLabel.TabIndex = 28;
            this.currentOpportunityLabel.Text = "Current Opportunity";
            this.currentOpportunityLabel.Visible = false;
            // 
            // pastDGV
            // 
            this.pastDGV.AllowUserToAddRows = false;
            this.pastDGV.AllowUserToDeleteRows = false;
            this.pastDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.pastDGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.pastDGV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pastDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pastDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pastDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.Expected,
            this.Pessimistic,
            this.Optimistic});
            this.pastDGV.Location = new System.Drawing.Point(16, 509);
            this.pastDGV.Name = "pastDGV";
            this.pastDGV.ReadOnly = true;
            this.pastDGV.RowHeadersVisible = false;
            this.pastDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pastDGV.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.pastDGV.Size = new System.Drawing.Size(509, 326);
            this.pastDGV.TabIndex = 29;
            this.pastDGV.Visible = false;
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
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(50, 777);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(152, 20);
            this.firstNameTextBox.TabIndex = 30;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.Location = new System.Drawing.Point(46, 754);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(86, 20);
            this.firstNameLabel.TabIndex = 31;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(251, 754);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(86, 20);
            this.lastNameLabel.TabIndex = 32;
            this.lastNameLabel.Text = "Last Name";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(421, 754);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(26, 20);
            this.IDLabel.TabIndex = 33;
            this.IDLabel.Text = "ID";
            // 
            // classCodeLabel
            // 
            this.classCodeLabel.AutoSize = true;
            this.classCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classCodeLabel.Location = new System.Drawing.Point(574, 754);
            this.classCodeLabel.Name = "classCodeLabel";
            this.classCodeLabel.Size = new System.Drawing.Size(90, 20);
            this.classCodeLabel.TabIndex = 34;
            this.classCodeLabel.Text = "Class Code";
            // 
            // classNumberLabel
            // 
            this.classNumberLabel.AutoSize = true;
            this.classNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNumberLabel.Location = new System.Drawing.Point(779, 755);
            this.classNumberLabel.Name = "classNumberLabel";
            this.classNumberLabel.Size = new System.Drawing.Size(108, 20);
            this.classNumberLabel.TabIndex = 35;
            this.classNumberLabel.Text = "Class Number";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(255, 777);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(145, 20);
            this.lastNameTextBox.TabIndex = 36;
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(425, 777);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(119, 20);
            this.IDTextBox.TabIndex = 37;
            this.IDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // classNumberTextBox
            // 
            this.classNumberTextBox.Location = new System.Drawing.Point(783, 777);
            this.classNumberTextBox.Name = "classNumberTextBox";
            this.classNumberTextBox.Size = new System.Drawing.Size(145, 20);
            this.classNumberTextBox.TabIndex = 38;
            this.classNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDTextBox_KeyPress);
            // 
            // classCodeBox
            // 
            this.classCodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classCodeBox.FormattingEnabled = true;
            this.classCodeBox.Items.AddRange(new object[] {
            "DSCI",
            "MISC",
            "CSCD"});
            this.classCodeBox.Location = new System.Drawing.Point(578, 777);
            this.classCodeBox.Name = "classCodeBox";
            this.classCodeBox.Size = new System.Drawing.Size(152, 21);
            this.classCodeBox.TabIndex = 39;
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(953, 764);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(119, 34);
            this.playButton.TabIndex = 40;
            this.playButton.Text = "Let\'s Play!";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoEllipsis = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(16, 70);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(1086, 653);
            this.instructionLabel.TabIndex = 41;
            this.instructionLabel.Text = resources.GetString("instructionLabel.Text");
            // 
            // instrucLabel
            // 
            this.instrucLabel.AutoSize = true;
            this.instrucLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucLabel.Location = new System.Drawing.Point(20, 28);
            this.instrucLabel.Name = "instrucLabel";
            this.instrucLabel.Size = new System.Drawing.Size(122, 24);
            this.instrucLabel.TabIndex = 42;
            this.instrucLabel.Text = "Instructions:";
            // 
            // describeBtn
            // 
            this.describeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.describeBtn.Location = new System.Drawing.Point(615, 529);
            this.describeBtn.Name = "describeBtn";
            this.describeBtn.Size = new System.Drawing.Size(161, 73);
            this.describeBtn.TabIndex = 43;
            this.describeBtn.Text = "Describe";
            this.describeBtn.UseVisualStyleBackColor = true;
            this.describeBtn.Visible = false;
            this.describeBtn.Click += new System.EventHandler(this.describeBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 846);
            this.Controls.Add(this.describeBtn);
            this.Controls.Add(this.instrucLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.classCodeBox);
            this.Controls.Add(this.classNumberTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.classNumberLabel);
            this.Controls.Add(this.classCodeLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.opportunityDisplay);
            this.Controls.Add(this.currentOpportunityLabel);
            this.Controls.Add(this.pastOpportunityLabel);
            this.Controls.Add(this.oppButton);
            this.Controls.Add(this.pastOpportunityDisplay);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.maxCharacterLabel);
            this.Controls.Add(this.explainLabel);
            this.Controls.Add(this.explanationTextBox);
            this.Controls.Add(this.rejectOppButton);
            this.Controls.Add(this.acceptOppButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pastDGV);
            this.Controls.Add(this.instructionLabel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Entrepreneur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pastDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button oppButton;
        private System.Windows.Forms.Button acceptOppButton;
        private System.Windows.Forms.Button rejectOppButton;
        private System.Windows.Forms.TextBox explanationTextBox;
        private System.Windows.Forms.Label explainLabel;
        private System.Windows.Forms.Label maxCharacterLabel;
        private System.Windows.Forms.Label opportunityDisplay;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Label pastOpportunityDisplay;
        private System.Windows.Forms.Label pastOpportunityLabel;
        private System.Windows.Forms.Label currentOpportunityLabel;
        private System.Windows.Forms.DataGridView pastDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessimistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Optimistic;
        private System.Windows.Forms.ToolStripMenuItem restartBtn;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label classCodeLabel;
        private System.Windows.Forms.Label classNumberLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox classNumberTextBox;
        private System.Windows.Forms.ComboBox classCodeBox;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label instrucLabel;
        private System.Windows.Forms.Button describeBtn;
    }
}

