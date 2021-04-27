
namespace ParticleSwarm
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
            this.components = new System.ComponentModel.Container();
            this.testBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.dBox = new System.Windows.Forms.TextBox();
            this.bBox = new System.Windows.Forms.TextBox();
            this.aBox = new System.Windows.Forms.TextBox();
            this.NBox = new System.Windows.Forms.TextBox();
            this.N = new System.Windows.Forms.Label();
            this.C1Box = new System.Windows.Forms.TextBox();
            this.C2Box = new System.Windows.Forms.TextBox();
            this.C3Box = new System.Windows.Forms.TextBox();
            this.RSBox = new System.Windows.Forms.TextBox();
            this.lbab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.DataGridView();
            this.particleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(713, 6);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(75, 23);
            this.testBtn.TabIndex = 37;
            this.testBtn.Text = "testy";
            this.testBtn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "T";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "d";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "b";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "a";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(632, 6);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 32;
            this.startBtn.Text = "start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(253, 9);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(100, 20);
            this.Tbox.TabIndex = 31;
            this.Tbox.Text = "900";
            // 
            // dBox
            // 
            this.dBox.Location = new System.Drawing.Point(139, 6);
            this.dBox.Name = "dBox";
            this.dBox.Size = new System.Drawing.Size(72, 20);
            this.dBox.TabIndex = 30;
            this.dBox.Text = "0,001";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(79, 6);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(21, 20);
            this.bBox.TabIndex = 29;
            this.bBox.Text = "12";
            // 
            // aBox
            // 
            this.aBox.Location = new System.Drawing.Point(31, 5);
            this.aBox.Name = "aBox";
            this.aBox.Size = new System.Drawing.Size(23, 20);
            this.aBox.TabIndex = 28;
            this.aBox.Text = "-4";
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(391, 8);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(100, 20);
            this.NBox.TabIndex = 38;
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Location = new System.Drawing.Point(370, 12);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(15, 13);
            this.N.TabIndex = 39;
            this.N.Text = "N";
            // 
            // C1Box
            // 
            this.C1Box.Location = new System.Drawing.Point(31, 45);
            this.C1Box.Name = "C1Box";
            this.C1Box.Size = new System.Drawing.Size(42, 20);
            this.C1Box.TabIndex = 40;
            // 
            // C2Box
            // 
            this.C2Box.Location = new System.Drawing.Point(123, 45);
            this.C2Box.Name = "C2Box";
            this.C2Box.Size = new System.Drawing.Size(34, 20);
            this.C2Box.TabIndex = 41;
            // 
            // C3Box
            // 
            this.C3Box.Location = new System.Drawing.Point(218, 45);
            this.C3Box.Name = "C3Box";
            this.C3Box.Size = new System.Drawing.Size(29, 20);
            this.C3Box.TabIndex = 42;
            // 
            // RSBox
            // 
            this.RSBox.Location = new System.Drawing.Point(393, 45);
            this.RSBox.Name = "RSBox";
            this.RSBox.Size = new System.Drawing.Size(100, 20);
            this.RSBox.TabIndex = 43;
            // 
            // lbab
            // 
            this.lbab.AutoSize = true;
            this.lbab.Location = new System.Drawing.Point(5, 48);
            this.lbab.Name = "lbab";
            this.lbab.Size = new System.Drawing.Size(20, 13);
            this.lbab.TabIndex = 44;
            this.lbab.Text = "C1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "C2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "C3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Rozmiar sasiedztwa";
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AutoGenerateColumns = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.xrealDataGridViewTextBoxColumn,
            this.fxDataGridViewTextBoxColumn});
            this.table.DataSource = this.particleBindingSource;
            this.table.Location = new System.Drawing.Point(15, 95);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(439, 60);
            this.table.TabIndex = 48;
            // 
            // particleBindingSource
            // 
            this.particleBindingSource.DataSource = typeof(ParticleSwarm.classes.Particle);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xrealDataGridViewTextBoxColumn
            // 
            this.xrealDataGridViewTextBoxColumn.DataPropertyName = "Xreal";
            this.xrealDataGridViewTextBoxColumn.HeaderText = "Xreal";
            this.xrealDataGridViewTextBoxColumn.Name = "xrealDataGridViewTextBoxColumn";
            this.xrealDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fxDataGridViewTextBoxColumn
            // 
            this.fxDataGridViewTextBoxColumn.DataPropertyName = "Fx";
            this.fxDataGridViewTextBoxColumn.HeaderText = "Fx";
            this.fxDataGridViewTextBoxColumn.Name = "fxDataGridViewTextBoxColumn";
            this.fxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbab);
            this.Controls.Add(this.RSBox);
            this.Controls.Add(this.C3Box);
            this.Controls.Add(this.C2Box);
            this.Controls.Add(this.C1Box);
            this.Controls.Add(this.N);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.dBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.aBox);
            this.Name = "Form1";
            this.Text = "Particle Swarm";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.TextBox dBox;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox aBox;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.TextBox C1Box;
        private System.Windows.Forms.TextBox C2Box;
        private System.Windows.Forms.TextBox C3Box;
        private System.Windows.Forms.TextBox RSBox;
        private System.Windows.Forms.Label lbab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xrealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource particleBindingSource;
    }
}

