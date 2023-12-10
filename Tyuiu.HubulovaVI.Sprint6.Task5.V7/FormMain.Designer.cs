
namespace Tyuiu.HubulovaVI.Sprint6.Task5.V7
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelCondition = new System.Windows.Forms.Panel();
            this.groupBoxCondition = new System.Windows.Forms.GroupBox();
            this.labelCondition = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelCenter = new System.Windows.Forms.Panel();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.panelCondition.SuspendLayout();
            this.groupBoxCondition.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.panelCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCondition
            // 
            this.panelCondition.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCondition.Controls.Add(this.buttonInfo);
            this.panelCondition.Controls.Add(this.buttonOpenFile);
            this.panelCondition.Controls.Add(this.buttonResult);
            this.panelCondition.Controls.Add(this.groupBoxCondition);
            this.panelCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCondition.Location = new System.Drawing.Point(0, 0);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Size = new System.Drawing.Size(988, 72);
            this.panelCondition.TabIndex = 0;
            // 
            // groupBoxCondition
            // 
            this.groupBoxCondition.Controls.Add(this.labelCondition);
            this.groupBoxCondition.Location = new System.Drawing.Point(4, 4);
            this.groupBoxCondition.Name = "groupBoxCondition";
            this.groupBoxCondition.Size = new System.Drawing.Size(379, 88);
            this.groupBoxCondition.TabIndex = 0;
            this.groupBoxCondition.TabStop = false;
            this.groupBoxCondition.Text = "Условие:";
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(8, 26);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(365, 39);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView\r\nположительн" +
    "ые значения и построить диаграмму по этим значениям.\r\n\r\n";
            // 
            // buttonResult
            // 
            this.buttonResult.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonResult.Location = new System.Drawing.Point(709, 4);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(88, 65);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "Выполнить";
            this.buttonResult.UseVisualStyleBackColor = false;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonOpenFile.Location = new System.Drawing.Point(803, 4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(88, 65);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonInfo.Location = new System.Drawing.Point(897, 4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(88, 65);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Справка";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelLeft.Controls.Add(this.groupBoxOutput);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 72);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Padding = new System.Windows.Forms.Padding(5);
            this.panelLeft.Size = new System.Drawing.Size(200, 552);
            this.panelLeft.TabIndex = 1;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewResult);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxOutput.Location = new System.Drawing.Point(5, 5);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(187, 542);
            this.groupBoxOutput.TabIndex = 0;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод данных:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 72);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 552);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelCenter
            // 
            this.panelCenter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCenter.Controls.Add(this.chartResult);
            this.panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCenter.Location = new System.Drawing.Point(203, 72);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(785, 552);
            this.panelCenter.TabIndex = 3;
            // 
            // chartResult
            // 
            chartArea3.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea3);
            this.chartResult.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartResult.Legends.Add(legend3);
            this.chartResult.Location = new System.Drawing.Point(0, 0);
            this.chartResult.Name = "chartResult";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartResult.Series.Add(series3);
            this.chartResult.Size = new System.Drawing.Size(785, 552);
            this.chartResult.TabIndex = 0;
            this.chartResult.Text = "chart1";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(181, 523);
            this.dataGridViewResult.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 624);
            this.Controls.Add(this.panelCenter);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelCondition);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 7 | Хубулова В. И.";
            this.panelCondition.ResumeLayout(false);
            this.groupBoxCondition.ResumeLayout(false);
            this.groupBoxCondition.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.panelCenter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}

