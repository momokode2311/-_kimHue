namespace 携帯会社販売管理システム
{
    partial class WareHousingInsert
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.grvWareHousingInsert = new System.Windows.Forms.DataGridView();
            this.SNumber = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWHS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDt = new System.Windows.Forms.TextBox();
            this.dtPickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvWareHousingInsert)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btnExit);
            this.panel3.Controls.Add(this.btnInsert);
            this.panel3.Location = new System.Drawing.Point(22, 623);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 43);
            this.panel3.TabIndex = 31;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(618, 5);
            this.btnExit.Margin = new System.Windows.Forms.Padding(20, 2, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(130, 34);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "戻る";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightGray;
            this.btnInsert.Location = new System.Drawing.Point(6, 6);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(134, 34);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "登録";
            this.btnInsert.UseVisualStyleBackColor = false;
            // 
            // grvWareHousingInsert
            // 
            this.grvWareHousingInsert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvWareHousingInsert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNumber,
            this.SName,
            this.color,
            this.Column1,
            this.Column6,
            this.Column2});
            this.grvWareHousingInsert.Location = new System.Drawing.Point(22, 230);
            this.grvWareHousingInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grvWareHousingInsert.Name = "grvWareHousingInsert";
            this.grvWareHousingInsert.RowTemplate.Height = 24;
            this.grvWareHousingInsert.Size = new System.Drawing.Size(763, 387);
            this.grvWareHousingInsert.TabIndex = 30;
            // 
            // SNumber
            // 
            this.SNumber.HeaderText = "商品番号";
            this.SNumber.Name = "SNumber";
            this.SNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SName
            // 
            this.SName.HeaderText = "商品名";
            this.SName.Name = "SName";
            this.SName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SName.Width = 120;
            // 
            // color
            // 
            this.color.HeaderText = "カラー";
            this.color.Name = "color";
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.color.Width = 60;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "入荷数量";
            this.Column1.Name = "Column1";
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "単価";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column6.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "合計金額";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "入庫番号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWHS
            // 
            this.txtWHS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWHS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtWHS.Location = new System.Drawing.Point(101, 11);
            this.txtWHS.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtWHS.Name = "txtWHS";
            this.txtWHS.Size = new System.Drawing.Size(110, 20);
            this.txtWHS.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 33);
            this.label3.TabIndex = 14;
            this.label3.Text = "入庫日";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDt
            // 
            this.txtDt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDt.Location = new System.Drawing.Point(102, 45);
            this.txtDt.Margin = new System.Windows.Forms.Padding(3, 10, 0, 3);
            this.txtDt.Name = "txtDt";
            this.txtDt.Size = new System.Drawing.Size(90, 20);
            this.txtDt.TabIndex = 21;
            this.txtDt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtPickerFrom
            // 
            this.dtPickerFrom.AllowDrop = true;
            this.dtPickerFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtPickerFrom.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtPickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerFrom.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dtPickerFrom.Location = new System.Drawing.Point(192, 45);
            this.dtPickerFrom.Margin = new System.Windows.Forms.Padding(1, 10, 0, 3);
            this.dtPickerFrom.Name = "dtPickerFrom";
            this.dtPickerFrom.Size = new System.Drawing.Size(19, 20);
            this.dtPickerFrom.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtComment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtWHS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtDt);
            this.panel2.Controls.Add(this.dtPickerFrom);
            this.panel2.Location = new System.Drawing.Point(22, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 163);
            this.panel2.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(399, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 31);
            this.label4.TabIndex = 27;
            this.label4.Text = "担当者";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserName.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtUserName.Location = new System.Drawing.Point(497, 11);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(138, 20);
            this.txtUserName.TabIndex = 26;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(102, 84);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(345, 60);
            this.txtComment.TabIndex = 25;
            this.txtComment.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "備考";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTittle
            // 
            this.lblTittle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTittle.Location = new System.Drawing.Point(280, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(189, 33);
            this.lblTittle.TabIndex = 29;
            this.lblTittle.Text = "入庫情報登録";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WareHousingInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grvWareHousingInsert);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTittle);
            this.Name = "WareHousingInsert";
            this.Text = "WareHousingInsert";
            //this.Load += new System.EventHandler(this.WareHousingInsert_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvWareHousingInsert)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView grvWareHousingInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWHS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDt;
        private System.Windows.Forms.DateTimePicker dtPickerFrom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridViewComboBoxColumn SNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewComboBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}