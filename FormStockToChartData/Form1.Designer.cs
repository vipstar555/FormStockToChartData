namespace FormStockToChartData
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxTR = new System.Windows.Forms.CheckBox();
            this.checkBoxVora = new System.Windows.Forms.CheckBox();
            this.checkBoxMA = new System.Windows.Forms.CheckBox();
            this.checkBoxTorihiki = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(199, 5);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(111, 19);
            this.dateTimePickerTo.TabIndex = 0;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(53, 5);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(81, 19);
            this.textBoxCode.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(456, 3);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(75, 23);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "表示";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(339, 5);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(111, 19);
            this.dateTimePickerFrom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "コード";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "取得日付";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "～";
            // 
            // checkBoxTR
            // 
            this.checkBoxTR.AutoSize = true;
            this.checkBoxTR.Checked = true;
            this.checkBoxTR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTR.Location = new System.Drawing.Point(12, 30);
            this.checkBoxTR.Name = "checkBoxTR";
            this.checkBoxTR.Size = new System.Drawing.Size(39, 16);
            this.checkBoxTR.TabIndex = 7;
            this.checkBoxTR.Text = "TR";
            this.checkBoxTR.UseVisualStyleBackColor = true;
            // 
            // checkBoxVora
            // 
            this.checkBoxVora.AutoSize = true;
            this.checkBoxVora.Checked = true;
            this.checkBoxVora.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxVora.Location = new System.Drawing.Point(57, 30);
            this.checkBoxVora.Name = "checkBoxVora";
            this.checkBoxVora.Size = new System.Drawing.Size(42, 16);
            this.checkBoxVora.TabIndex = 8;
            this.checkBoxVora.Text = "ボラ";
            this.checkBoxVora.UseVisualStyleBackColor = true;
            // 
            // checkBoxMA
            // 
            this.checkBoxMA.AutoSize = true;
            this.checkBoxMA.Checked = true;
            this.checkBoxMA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMA.Location = new System.Drawing.Point(105, 30);
            this.checkBoxMA.Name = "checkBoxMA";
            this.checkBoxMA.Size = new System.Drawing.Size(71, 16);
            this.checkBoxMA.TabIndex = 9;
            this.checkBoxMA.Text = "5MA乖離";
            this.checkBoxMA.UseVisualStyleBackColor = true;
            // 
            // checkBoxTorihiki
            // 
            this.checkBoxTorihiki.AutoSize = true;
            this.checkBoxTorihiki.Checked = true;
            this.checkBoxTorihiki.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTorihiki.Location = new System.Drawing.Point(182, 30);
            this.checkBoxTorihiki.Name = "checkBoxTorihiki";
            this.checkBoxTorihiki.Size = new System.Drawing.Size(72, 16);
            this.checkBoxTorihiki.TabIndex = 10;
            this.checkBoxTorihiki.Text = "取引比率";
            this.checkBoxTorihiki.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 55);
            this.Controls.Add(this.checkBoxTorihiki);
            this.Controls.Add(this.checkBoxMA);
            this.Controls.Add(this.checkBoxVora);
            this.Controls.Add(this.checkBoxTR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.dateTimePickerTo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxTR;
        private System.Windows.Forms.CheckBox checkBoxVora;
        private System.Windows.Forms.CheckBox checkBoxMA;
        private System.Windows.Forms.CheckBox checkBoxTorihiki;
    }
}

