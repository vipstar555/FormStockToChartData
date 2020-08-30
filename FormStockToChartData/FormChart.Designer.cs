namespace FormStockToChartData
{
    partial class FormChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.radioButtonTR = new System.Windows.Forms.RadioButton();
            this.radioButtonBora = new System.Windows.Forms.RadioButton();
            this.radioButtonMAkairi = new System.Windows.Forms.RadioButton();
            this.radioButtonTorihiki = new System.Windows.Forms.RadioButton();
            this.checkBoxTR = new System.Windows.Forms.CheckBox();
            this.checkBoxBora = new System.Windows.Forms.CheckBox();
            this.checkBoxMA = new System.Windows.Forms.CheckBox();
            this.checkBoxTorihiki = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart1.Series.Add(series7);
            this.chart1.Size = new System.Drawing.Size(800, 453);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Chart1_MouseMove);
            // 
            // radioButtonTR
            // 
            this.radioButtonTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTR.AutoSize = true;
            this.radioButtonTR.Checked = true;
            this.radioButtonTR.Location = new System.Drawing.Point(700, 355);
            this.radioButtonTR.Name = "radioButtonTR";
            this.radioButtonTR.Size = new System.Drawing.Size(38, 16);
            this.radioButtonTR.TabIndex = 1;
            this.radioButtonTR.TabStop = true;
            this.radioButtonTR.Text = "TR";
            this.radioButtonTR.UseVisualStyleBackColor = true;
            // 
            // radioButtonBora
            // 
            this.radioButtonBora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonBora.AutoSize = true;
            this.radioButtonBora.Location = new System.Drawing.Point(700, 374);
            this.radioButtonBora.Name = "radioButtonBora";
            this.radioButtonBora.Size = new System.Drawing.Size(41, 16);
            this.radioButtonBora.TabIndex = 2;
            this.radioButtonBora.Text = "ボラ";
            this.radioButtonBora.UseVisualStyleBackColor = true;
            // 
            // radioButtonMAkairi
            // 
            this.radioButtonMAkairi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonMAkairi.AutoSize = true;
            this.radioButtonMAkairi.Location = new System.Drawing.Point(699, 394);
            this.radioButtonMAkairi.Name = "radioButtonMAkairi";
            this.radioButtonMAkairi.Size = new System.Drawing.Size(70, 16);
            this.radioButtonMAkairi.TabIndex = 3;
            this.radioButtonMAkairi.Text = "5MA乖離";
            this.radioButtonMAkairi.UseVisualStyleBackColor = true;
            // 
            // radioButtonTorihiki
            // 
            this.radioButtonTorihiki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonTorihiki.AutoSize = true;
            this.radioButtonTorihiki.Location = new System.Drawing.Point(700, 413);
            this.radioButtonTorihiki.Name = "radioButtonTorihiki";
            this.radioButtonTorihiki.Size = new System.Drawing.Size(71, 16);
            this.radioButtonTorihiki.TabIndex = 4;
            this.radioButtonTorihiki.Text = "取引比率";
            this.radioButtonTorihiki.UseVisualStyleBackColor = true;
            // 
            // checkBoxTR
            // 
            this.checkBoxTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTR.AutoSize = true;
            this.checkBoxTR.Checked = true;
            this.checkBoxTR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTR.Location = new System.Drawing.Point(682, 356);
            this.checkBoxTR.Name = "checkBoxTR";
            this.checkBoxTR.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTR.TabIndex = 5;
            this.checkBoxTR.UseVisualStyleBackColor = true;
            this.checkBoxTR.CheckedChanged += new System.EventHandler(this.CheckBoxTR_CheckedChanged);
            // 
            // checkBoxBora
            // 
            this.checkBoxBora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxBora.AutoSize = true;
            this.checkBoxBora.Checked = true;
            this.checkBoxBora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBora.Location = new System.Drawing.Point(682, 376);
            this.checkBoxBora.Name = "checkBoxBora";
            this.checkBoxBora.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBora.TabIndex = 6;
            this.checkBoxBora.UseVisualStyleBackColor = true;
            this.checkBoxBora.CheckedChanged += new System.EventHandler(this.CheckBoxBora_CheckedChanged);
            // 
            // checkBoxMA
            // 
            this.checkBoxMA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMA.AutoSize = true;
            this.checkBoxMA.Checked = true;
            this.checkBoxMA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMA.Location = new System.Drawing.Point(682, 395);
            this.checkBoxMA.Name = "checkBoxMA";
            this.checkBoxMA.Size = new System.Drawing.Size(15, 14);
            this.checkBoxMA.TabIndex = 7;
            this.checkBoxMA.UseVisualStyleBackColor = true;
            this.checkBoxMA.CheckedChanged += new System.EventHandler(this.CheckBoxMA_CheckedChanged);
            // 
            // checkBoxTorihiki
            // 
            this.checkBoxTorihiki.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxTorihiki.AutoSize = true;
            this.checkBoxTorihiki.Checked = true;
            this.checkBoxTorihiki.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTorihiki.Location = new System.Drawing.Point(682, 414);
            this.checkBoxTorihiki.Name = "checkBoxTorihiki";
            this.checkBoxTorihiki.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTorihiki.TabIndex = 8;
            this.checkBoxTorihiki.UseVisualStyleBackColor = true;
            this.checkBoxTorihiki.CheckedChanged += new System.EventHandler(this.CheckBoxTorihiki_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(699, 330);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 19);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // FormChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxTorihiki);
            this.Controls.Add(this.checkBoxMA);
            this.Controls.Add(this.checkBoxBora);
            this.Controls.Add(this.checkBoxTR);
            this.Controls.Add(this.radioButtonTorihiki);
            this.Controls.Add(this.radioButtonMAkairi);
            this.Controls.Add(this.radioButtonBora);
            this.Controls.Add(this.radioButtonTR);
            this.Controls.Add(this.chart1);
            this.Name = "FormChart";
            this.Text = "FormChart";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton radioButtonTR;
        private System.Windows.Forms.RadioButton radioButtonBora;
        private System.Windows.Forms.RadioButton radioButtonMAkairi;
        private System.Windows.Forms.RadioButton radioButtonTorihiki;
        private System.Windows.Forms.CheckBox checkBoxTR;
        private System.Windows.Forms.CheckBox checkBoxBora;
        private System.Windows.Forms.CheckBox checkBoxMA;
        private System.Windows.Forms.CheckBox checkBoxTorihiki;
        private System.Windows.Forms.TextBox textBox1;
    }
}