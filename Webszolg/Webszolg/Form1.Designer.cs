
namespace Webszolg
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chartRate = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickertol = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerig = new System.Windows.Forms.DateTimePicker();
            this.cbvaluta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRate)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(211, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // chartRate
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRate.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRate.Legends.Add(legend1);
            this.chartRate.Location = new System.Drawing.Point(229, 78);
            this.chartRate.Name = "chartRate";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRate.Series.Add(series1);
            this.chartRate.Size = new System.Drawing.Size(559, 360);
            this.chartRate.TabIndex = 1;
            this.chartRate.Text = "chart1";
            // 
            // dateTimePickertol
            // 
            this.dateTimePickertol.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickertol.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickertol.Name = "dateTimePickertol";
            this.dateTimePickertol.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickertol.TabIndex = 2;
            this.dateTimePickertol.ValueChanged += new System.EventHandler(this.dateTimePickertol_ValueChanged);
            // 
            // dateTimePickerig
            // 
            this.dateTimePickerig.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerig.Location = new System.Drawing.Point(219, 11);
            this.dateTimePickerig.Name = "dateTimePickerig";
            this.dateTimePickerig.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerig.TabIndex = 3;
            this.dateTimePickerig.ValueChanged += new System.EventHandler(this.dateTimePickertol_ValueChanged);
            // 
            // cbvaluta
            // 
            this.cbvaluta.FormattingEnabled = true;
            this.cbvaluta.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.cbvaluta.Location = new System.Drawing.Point(426, 10);
            this.cbvaluta.Name = "cbvaluta";
            this.cbvaluta.Size = new System.Drawing.Size(121, 21);
            this.cbvaluta.TabIndex = 4;
            this.cbvaluta.SelectedIndexChanged += new System.EventHandler(this.dateTimePickertol_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbvaluta);
            this.Controls.Add(this.dateTimePickerig);
            this.Controls.Add(this.dateTimePickertol);
            this.Controls.Add(this.chartRate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRate;
        private System.Windows.Forms.DateTimePicker dateTimePickertol;
        private System.Windows.Forms.DateTimePicker dateTimePickerig;
        private System.Windows.Forms.ComboBox cbvaluta;
    }
}

