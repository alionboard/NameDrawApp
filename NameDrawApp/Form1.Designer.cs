namespace NameDrawApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.btnMix = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbExcludeMost = new System.Windows.Forms.RadioButton();
            this.rbBelowAvg = new System.Windows.Forms.RadioButton();
            this.rbFullRandom = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPeople.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPeople.Location = new System.Drawing.Point(20, 34);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(406, 329);
            this.dgvPeople.TabIndex = 0;
            // 
            // btnMix
            // 
            this.btnMix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMix.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMix.Location = new System.Drawing.Point(334, 24);
            this.btnMix.Name = "btnMix";
            this.btnMix.Size = new System.Drawing.Size(198, 97);
            this.btnMix.TabIndex = 1;
            this.btnMix.Text = "New Random";
            this.btnMix.UseVisualStyleBackColor = false;
            this.btnMix.Click += new System.EventHandler(this.btnMix_Click);
            // 
            // lstResults
            // 
            this.lstResults.BackColor = System.Drawing.SystemColors.Control;
            this.lstResults.DisplayMember = "Name";
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(445, 34);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(120, 329);
            this.lstResults.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Result Order";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblResult.Location = new System.Drawing.Point(20, 402);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(545, 63);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "?";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "The Chosen One";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(16, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(122, 26);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset Statistics";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rbExcludeMost
            // 
            this.rbExcludeMost.AutoSize = true;
            this.rbExcludeMost.Location = new System.Drawing.Point(16, 72);
            this.rbExcludeMost.Name = "rbExcludeMost";
            this.rbExcludeMost.Size = new System.Drawing.Size(97, 17);
            this.rbExcludeMost.TabIndex = 13;
            this.rbExcludeMost.Text = "Excluding Most";
            this.rbExcludeMost.UseVisualStyleBackColor = true;
            // 
            // rbBelowAvg
            // 
            this.rbBelowAvg.AutoSize = true;
            this.rbBelowAvg.Location = new System.Drawing.Point(16, 49);
            this.rbBelowAvg.Name = "rbBelowAvg";
            this.rbBelowAvg.Size = new System.Drawing.Size(97, 17);
            this.rbBelowAvg.TabIndex = 12;
            this.rbBelowAvg.Text = "Below Average";
            this.rbBelowAvg.UseVisualStyleBackColor = true;
            // 
            // rbFullRandom
            // 
            this.rbFullRandom.AutoSize = true;
            this.rbFullRandom.Checked = true;
            this.rbFullRandom.Location = new System.Drawing.Point(16, 26);
            this.rbFullRandom.Name = "rbFullRandom";
            this.rbFullRandom.Size = new System.Drawing.Size(36, 17);
            this.rbFullRandom.TabIndex = 11;
            this.rbFullRandom.TabStop = true;
            this.rbFullRandom.Text = "All";
            this.rbFullRandom.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.rbExcludeMost);
            this.groupBox1.Controls.Add(this.rbFullRandom);
            this.groupBox1.Controls.Add(this.rbBelowAvg);
            this.groupBox1.Controls.Add(this.btnMix);
            this.groupBox1.Location = new System.Drawing.Point(22, 487);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 133);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modes";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            this.Column1.FillWeight = 161.0009F;
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "LastDrawnTime";
            this.Column2.FillWeight = 90F;
            this.Column2.HeaderText = "Last Drawn";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DrawCount";
            this.Column3.FillWeight = 60.9137F;
            this.Column3.HeaderText = "Count";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.dgvPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 670);
            this.MinimumSize = new System.Drawing.Size(600, 670);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NameDraw";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Button btnMix;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbExcludeMost;
        private System.Windows.Forms.RadioButton rbBelowAvg;
        private System.Windows.Forms.RadioButton rbFullRandom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

