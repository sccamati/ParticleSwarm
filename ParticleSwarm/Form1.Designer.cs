
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xrealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.animationBtn = new System.Windows.Forms.Button();
            this.animationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.testPanel = new System.Windows.Forms.Panel();
            this.testTable = new System.Windows.Forms.DataGridView();
            this.c1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countBestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zad1Btn = new System.Windows.Forms.Button();
            this.startTestBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationChart)).BeginInit();
            this.testPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testClassBindingSource)).BeginInit();
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
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
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
            this.Tbox.Text = "600";
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
            this.NBox.Text = "50";
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
            this.C1Box.Text = "1";
            // 
            // C2Box
            // 
            this.C2Box.Location = new System.Drawing.Point(123, 45);
            this.C2Box.Name = "C2Box";
            this.C2Box.Size = new System.Drawing.Size(34, 20);
            this.C2Box.TabIndex = 41;
            this.C2Box.Text = "2";
            // 
            // C3Box
            // 
            this.C3Box.Location = new System.Drawing.Point(218, 45);
            this.C3Box.Name = "C3Box";
            this.C3Box.Size = new System.Drawing.Size(29, 20);
            this.C3Box.TabIndex = 42;
            this.C3Box.Text = "2";
            // 
            // RSBox
            // 
            this.RSBox.Location = new System.Drawing.Point(393, 45);
            this.RSBox.Name = "RSBox";
            this.RSBox.Size = new System.Drawing.Size(100, 20);
            this.RSBox.TabIndex = 43;
            this.RSBox.Text = "30";
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
            this.table.Location = new System.Drawing.Point(8, 71);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(447, 61);
            this.table.TabIndex = 48;
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
            // particleBindingSource
            // 
            this.particleBindingSource.DataSource = typeof(ParticleSwarm.classes.Particle);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "%";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(8, 149);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1113, 473);
            this.chart.TabIndex = 50;
            this.chart.Text = "chart1";
            // 
            // animationBtn
            // 
            this.animationBtn.Location = new System.Drawing.Point(632, 41);
            this.animationBtn.Name = "animationBtn";
            this.animationBtn.Size = new System.Drawing.Size(75, 23);
            this.animationBtn.TabIndex = 52;
            this.animationBtn.Text = "animacja";
            this.animationBtn.UseVisualStyleBackColor = true;
            this.animationBtn.Click += new System.EventHandler(this.animationBtn_Click);
            // 
            // animationChart
            // 
            chartArea2.Name = "ChartArea1";
            this.animationChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.animationChart.Legends.Add(legend2);
            this.animationChart.Location = new System.Drawing.Point(12, 628);
            this.animationChart.Name = "animationChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.animationChart.Series.Add(series2);
            this.animationChart.Size = new System.Drawing.Size(1109, 117);
            this.animationChart.TabIndex = 53;
            this.animationChart.Text = "chart1";
            // 
            // testPanel
            // 
            this.testPanel.Controls.Add(this.testTable);
            this.testPanel.Controls.Add(this.zad1Btn);
            this.testPanel.Controls.Add(this.startTestBtn);
            this.testPanel.Location = new System.Drawing.Point(8, 5);
            this.testPanel.Name = "testPanel";
            this.testPanel.Size = new System.Drawing.Size(1125, 739);
            this.testPanel.TabIndex = 54;
            // 
            // testTable
            // 
            this.testTable.AllowUserToAddRows = false;
            this.testTable.AllowUserToDeleteRows = false;
            this.testTable.AutoGenerateColumns = false;
            this.testTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1DataGridViewTextBoxColumn,
            this.c2DataGridViewTextBoxColumn,
            this.c3DataGridViewTextBoxColumn,
            this.tDataGridViewTextBoxColumn,
            this.rSDataGridViewTextBoxColumn,
            this.nDataGridViewTextBoxColumn,
            this.maxDataGridViewTextBoxColumn,
            this.avgDataGridViewTextBoxColumn,
            this.countBestDataGridViewTextBoxColumn});
            this.testTable.DataSource = this.testClassBindingSource;
            this.testTable.Location = new System.Drawing.Point(23, 65);
            this.testTable.Name = "testTable";
            this.testTable.ReadOnly = true;
            this.testTable.Size = new System.Drawing.Size(939, 447);
            this.testTable.TabIndex = 2;
            // 
            // c1DataGridViewTextBoxColumn
            // 
            this.c1DataGridViewTextBoxColumn.DataPropertyName = "c1";
            this.c1DataGridViewTextBoxColumn.HeaderText = "c1";
            this.c1DataGridViewTextBoxColumn.Name = "c1DataGridViewTextBoxColumn";
            this.c1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c2DataGridViewTextBoxColumn
            // 
            this.c2DataGridViewTextBoxColumn.DataPropertyName = "c2";
            this.c2DataGridViewTextBoxColumn.HeaderText = "c2";
            this.c2DataGridViewTextBoxColumn.Name = "c2DataGridViewTextBoxColumn";
            this.c2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // c3DataGridViewTextBoxColumn
            // 
            this.c3DataGridViewTextBoxColumn.DataPropertyName = "c3";
            this.c3DataGridViewTextBoxColumn.HeaderText = "c3";
            this.c3DataGridViewTextBoxColumn.Name = "c3DataGridViewTextBoxColumn";
            this.c3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "t";
            this.tDataGridViewTextBoxColumn.HeaderText = "t";
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            this.tDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rSDataGridViewTextBoxColumn
            // 
            this.rSDataGridViewTextBoxColumn.DataPropertyName = "RS";
            this.rSDataGridViewTextBoxColumn.HeaderText = "RS";
            this.rSDataGridViewTextBoxColumn.Name = "rSDataGridViewTextBoxColumn";
            this.rSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nDataGridViewTextBoxColumn
            // 
            this.nDataGridViewTextBoxColumn.DataPropertyName = "n";
            this.nDataGridViewTextBoxColumn.HeaderText = "n";
            this.nDataGridViewTextBoxColumn.Name = "nDataGridViewTextBoxColumn";
            this.nDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maxDataGridViewTextBoxColumn
            // 
            this.maxDataGridViewTextBoxColumn.DataPropertyName = "Max";
            this.maxDataGridViewTextBoxColumn.HeaderText = "Max";
            this.maxDataGridViewTextBoxColumn.Name = "maxDataGridViewTextBoxColumn";
            this.maxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // avgDataGridViewTextBoxColumn
            // 
            this.avgDataGridViewTextBoxColumn.DataPropertyName = "Avg";
            this.avgDataGridViewTextBoxColumn.HeaderText = "Avg";
            this.avgDataGridViewTextBoxColumn.Name = "avgDataGridViewTextBoxColumn";
            this.avgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countBestDataGridViewTextBoxColumn
            // 
            this.countBestDataGridViewTextBoxColumn.DataPropertyName = "CountBest";
            this.countBestDataGridViewTextBoxColumn.HeaderText = "CountBest";
            this.countBestDataGridViewTextBoxColumn.Name = "countBestDataGridViewTextBoxColumn";
            this.countBestDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // testClassBindingSource
            // 
            this.testClassBindingSource.DataSource = typeof(ParticleSwarm.classes.TestClass);
            // 
            // zad1Btn
            // 
            this.zad1Btn.Location = new System.Drawing.Point(131, 19);
            this.zad1Btn.Name = "zad1Btn";
            this.zad1Btn.Size = new System.Drawing.Size(75, 23);
            this.zad1Btn.TabIndex = 1;
            this.zad1Btn.Text = "algorytm";
            this.zad1Btn.UseVisualStyleBackColor = true;
            this.zad1Btn.Click += new System.EventHandler(this.zad1Btn_Click);
            // 
            // startTestBtn
            // 
            this.startTestBtn.Location = new System.Drawing.Point(34, 19);
            this.startTestBtn.Name = "startTestBtn";
            this.startTestBtn.Size = new System.Drawing.Size(75, 23);
            this.startTestBtn.TabIndex = 0;
            this.startTestBtn.Text = "start";
            this.startTestBtn.UseVisualStyleBackColor = true;
            this.startTestBtn.Click += new System.EventHandler(this.startTestBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 757);
            this.Controls.Add(this.testPanel);
            this.Controls.Add(this.animationChart);
            this.Controls.Add(this.animationBtn);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animationChart)).EndInit();
            this.testPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testClassBindingSource)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button animationBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart animationChart;
        private System.Windows.Forms.Panel testPanel;
        private System.Windows.Forms.DataGridView testTable;
        private System.Windows.Forms.Button zad1Btn;
        private System.Windows.Forms.Button startTestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countBestDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource testClassBindingSource;
    }
}

