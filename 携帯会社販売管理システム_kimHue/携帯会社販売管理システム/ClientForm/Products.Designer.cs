namespace 携帯会社販売管理システム
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btBack = new System.Windows.Forms.Button();
            this.btPrList = new System.Windows.Forms.Button();
            this.btPrUpdate = new System.Windows.Forms.Button();
            this.btPrRegistration = new System.Windows.Forms.Button();
            this.btPrRearch = new System.Windows.Forms.Button();
            this.dataGridViewPr = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxPrFlag = new System.Windows.Forms.ComboBox();
            this.PrDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxPrCode = new System.Windows.Forms.TextBox();
            this.textBoxPrColor = new System.Windows.Forms.TextBox();
            this.textBoxPrNum = new System.Windows.Forms.TextBox();
            this.textBoxPrHidden = new System.Windows.Forms.TextBox();
            this.textBoxPrTotal = new System.Windows.Forms.TextBox();
            this.textBoxPrUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxPrSaleOf = new System.Windows.Forms.TextBox();
            this.textBoxPrName = new System.Windows.Forms.TextBox();
            this.textBoxPrID = new System.Windows.Forms.TextBox();
            this.labelPrFlag = new System.Windows.Forms.Label();
            this.labelPrDate = new System.Windows.Forms.Label();
            this.labelPrCode = new System.Windows.Forms.Label();
            this.labelPrColor = new System.Windows.Forms.Label();
            this.labelPrNum = new System.Windows.Forms.Label();
            this.labelPrHidden = new System.Windows.Forms.Label();
            this.labelPrTotal = new System.Windows.Forms.Label();
            this.labelPrUnitPrice = new System.Windows.Forms.Label();
            this.labelPrSaleOf = new System.Windows.Forms.Label();
            this.labelPrName = new System.Windows.Forms.Label();
            this.labelPrID = new System.Windows.Forms.Label();
            this.mProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPr)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridViewPr);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(9, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 604);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btBack);
            this.panel3.Controls.Add(this.btPrList);
            this.panel3.Controls.Add(this.btPrUpdate);
            this.panel3.Controls.Add(this.btPrRegistration);
            this.panel3.Controls.Add(this.btPrRearch);
            this.panel3.Location = new System.Drawing.Point(17, 310);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 90);
            this.panel3.TabIndex = 2;
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(370, 33);
            this.btBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(57, 20);
            this.btBack.TabIndex = 4;
            this.btBack.Text = "戻る";
            this.btBack.UseVisualStyleBackColor = true;
            // 
            // btPrList
            // 
            this.btPrList.Location = new System.Drawing.Point(291, 33);
            this.btPrList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPrList.Name = "btPrList";
            this.btPrList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btPrList.Size = new System.Drawing.Size(56, 20);
            this.btPrList.TabIndex = 3;
            this.btPrList.Text = "一覧表示";
            this.btPrList.UseVisualStyleBackColor = true;
            this.btPrList.Click += new System.EventHandler(this.btPrList_Click);
            // 
            // btPrUpdate
            // 
            this.btPrUpdate.Location = new System.Drawing.Point(197, 33);
            this.btPrUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPrUpdate.Name = "btPrUpdate";
            this.btPrUpdate.Size = new System.Drawing.Size(56, 20);
            this.btPrUpdate.TabIndex = 2;
            this.btPrUpdate.Text = "更新";
            this.btPrUpdate.UseVisualStyleBackColor = true;
            this.btPrUpdate.Click += new System.EventHandler(this.btPrUpdate_Click);
            // 
            // btPrRegistration
            // 
            this.btPrRegistration.Location = new System.Drawing.Point(105, 33);
            this.btPrRegistration.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPrRegistration.Name = "btPrRegistration";
            this.btPrRegistration.Size = new System.Drawing.Size(56, 20);
            this.btPrRegistration.TabIndex = 1;
            this.btPrRegistration.Text = "登録";
            this.btPrRegistration.UseVisualStyleBackColor = true;
            // 
            // btPrRearch
            // 
            this.btPrRearch.Location = new System.Drawing.Point(14, 33);
            this.btPrRearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btPrRearch.Name = "btPrRearch";
            this.btPrRearch.Size = new System.Drawing.Size(56, 20);
            this.btPrRearch.TabIndex = 0;
            this.btPrRearch.Text = "検索";
            this.btPrRearch.UseVisualStyleBackColor = true;
            this.btPrRearch.Click += new System.EventHandler(this.btPrRearch_Click);
            // 
            // dataGridViewPr
            // 
            this.dataGridViewPr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPr.Location = new System.Drawing.Point(17, 424);
            this.dataGridViewPr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridViewPr.Name = "dataGridViewPr";
            this.dataGridViewPr.RowHeadersWidth = 51;
            this.dataGridViewPr.RowTemplate.Height = 24;
            this.dataGridViewPr.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewPr.Size = new System.Drawing.Size(572, 142);
            this.dataGridViewPr.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxPrFlag);
            this.panel2.Controls.Add(this.PrDate);
            this.panel2.Controls.Add(this.textBoxPrCode);
            this.panel2.Controls.Add(this.textBoxPrColor);
            this.panel2.Controls.Add(this.textBoxPrNum);
            this.panel2.Controls.Add(this.textBoxPrHidden);
            this.panel2.Controls.Add(this.textBoxPrTotal);
            this.panel2.Controls.Add(this.textBoxPrUnitPrice);
            this.panel2.Controls.Add(this.textBoxPrSaleOf);
            this.panel2.Controls.Add(this.textBoxPrName);
            this.panel2.Controls.Add(this.textBoxPrID);
            this.panel2.Controls.Add(this.labelPrFlag);
            this.panel2.Controls.Add(this.labelPrDate);
            this.panel2.Controls.Add(this.labelPrCode);
            this.panel2.Controls.Add(this.labelPrColor);
            this.panel2.Controls.Add(this.labelPrNum);
            this.panel2.Controls.Add(this.labelPrHidden);
            this.panel2.Controls.Add(this.labelPrTotal);
            this.panel2.Controls.Add(this.labelPrUnitPrice);
            this.panel2.Controls.Add(this.labelPrSaleOf);
            this.panel2.Controls.Add(this.labelPrName);
            this.panel2.Controls.Add(this.labelPrID);
            this.panel2.Location = new System.Drawing.Point(17, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 275);
            this.panel2.TabIndex = 0;
            // 
            // comboBoxPrFlag
            // 
            this.comboBoxPrFlag.FormattingEnabled = true;
            this.comboBoxPrFlag.Items.AddRange(new object[] {
            "0",
            "1"});
            this.comboBoxPrFlag.Location = new System.Drawing.Point(337, 239);
            this.comboBoxPrFlag.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxPrFlag.Name = "comboBoxPrFlag";
            this.comboBoxPrFlag.Size = new System.Drawing.Size(92, 21);
            this.comboBoxPrFlag.TabIndex = 21;
            // 
            // PrDate
            // 
            this.PrDate.Location = new System.Drawing.Point(337, 201);
            this.PrDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PrDate.Name = "PrDate";
            this.PrDate.Size = new System.Drawing.Size(128, 20);
            this.PrDate.TabIndex = 20;
            // 
            // textBoxPrCode
            // 
            this.textBoxPrCode.Location = new System.Drawing.Point(337, 157);
            this.textBoxPrCode.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrCode.Name = "textBoxPrCode";
            this.textBoxPrCode.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrCode.TabIndex = 19;
            // 
            // textBoxPrColor
            // 
            this.textBoxPrColor.Location = new System.Drawing.Point(337, 111);
            this.textBoxPrColor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrColor.Name = "textBoxPrColor";
            this.textBoxPrColor.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrColor.TabIndex = 18;
            // 
            // textBoxPrNum
            // 
            this.textBoxPrNum.Location = new System.Drawing.Point(337, 67);
            this.textBoxPrNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrNum.Name = "textBoxPrNum";
            this.textBoxPrNum.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrNum.TabIndex = 17;
            // 
            // textBoxPrHidden
            // 
            this.textBoxPrHidden.Location = new System.Drawing.Point(337, 19);
            this.textBoxPrHidden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrHidden.Name = "textBoxPrHidden";
            this.textBoxPrHidden.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrHidden.TabIndex = 16;
            // 
            // textBoxPrTotal
            // 
            this.textBoxPrTotal.Location = new System.Drawing.Point(67, 210);
            this.textBoxPrTotal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrTotal.Name = "textBoxPrTotal";
            this.textBoxPrTotal.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrTotal.TabIndex = 15;
            // 
            // textBoxPrUnitPrice
            // 
            this.textBoxPrUnitPrice.Location = new System.Drawing.Point(67, 159);
            this.textBoxPrUnitPrice.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrUnitPrice.Name = "textBoxPrUnitPrice";
            this.textBoxPrUnitPrice.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrUnitPrice.TabIndex = 14;
            // 
            // textBoxPrSaleOf
            // 
            this.textBoxPrSaleOf.Location = new System.Drawing.Point(67, 108);
            this.textBoxPrSaleOf.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrSaleOf.Name = "textBoxPrSaleOf";
            this.textBoxPrSaleOf.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrSaleOf.TabIndex = 13;
            // 
            // textBoxPrName
            // 
            this.textBoxPrName.Location = new System.Drawing.Point(67, 63);
            this.textBoxPrName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrName.Name = "textBoxPrName";
            this.textBoxPrName.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrName.TabIndex = 12;
            // 
            // textBoxPrID
            // 
            this.textBoxPrID.Location = new System.Drawing.Point(67, 19);
            this.textBoxPrID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPrID.Name = "textBoxPrID";
            this.textBoxPrID.Size = new System.Drawing.Size(76, 20);
            this.textBoxPrID.TabIndex = 11;
            // 
            // labelPrFlag
            // 
            this.labelPrFlag.AutoSize = true;
            this.labelPrFlag.Location = new System.Drawing.Point(263, 239);
            this.labelPrFlag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrFlag.Name = "labelPrFlag";
            this.labelPrFlag.Size = new System.Drawing.Size(32, 13);
            this.labelPrFlag.TabIndex = 10;
            this.labelPrFlag.Text = "フラグ";
            // 
            // labelPrDate
            // 
            this.labelPrDate.AutoSize = true;
            this.labelPrDate.Location = new System.Drawing.Point(263, 201);
            this.labelPrDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrDate.Name = "labelPrDate";
            this.labelPrDate.Size = new System.Drawing.Size(43, 13);
            this.labelPrDate.TabIndex = 9;
            this.labelPrDate.Text = "発売日";
            // 
            // labelPrCode
            // 
            this.labelPrCode.AutoSize = true;
            this.labelPrCode.Location = new System.Drawing.Point(263, 159);
            this.labelPrCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrCode.Name = "labelPrCode";
            this.labelPrCode.Size = new System.Drawing.Size(58, 13);
            this.labelPrCode.TabIndex = 8;
            this.labelPrCode.Text = "商品コード";
            // 
            // labelPrColor
            // 
            this.labelPrColor.AutoSize = true;
            this.labelPrColor.Location = new System.Drawing.Point(263, 111);
            this.labelPrColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrColor.Name = "labelPrColor";
            this.labelPrColor.Size = new System.Drawing.Size(46, 13);
            this.labelPrColor.TabIndex = 7;
            this.labelPrColor.Text = "カラー名";
            // 
            // labelPrNum
            // 
            this.labelPrNum.AutoSize = true;
            this.labelPrNum.Location = new System.Drawing.Point(263, 69);
            this.labelPrNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrNum.Name = "labelPrNum";
            this.labelPrNum.Size = new System.Drawing.Size(31, 13);
            this.labelPrNum.TabIndex = 6;
            this.labelPrNum.Text = "番号";
            // 
            // labelPrHidden
            // 
            this.labelPrHidden.AutoSize = true;
            this.labelPrHidden.Location = new System.Drawing.Point(263, 22);
            this.labelPrHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrHidden.Name = "labelPrHidden";
            this.labelPrHidden.Size = new System.Drawing.Size(67, 13);
            this.labelPrHidden.TabIndex = 5;
            this.labelPrHidden.Text = "非表示理由";
            // 
            // labelPrTotal
            // 
            this.labelPrTotal.AutoSize = true;
            this.labelPrTotal.Location = new System.Drawing.Point(12, 212);
            this.labelPrTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrTotal.Name = "labelPrTotal";
            this.labelPrTotal.Size = new System.Drawing.Size(55, 13);
            this.labelPrTotal.TabIndex = 4;
            this.labelPrTotal.Text = "合計金額";
            // 
            // labelPrUnitPrice
            // 
            this.labelPrUnitPrice.AutoSize = true;
            this.labelPrUnitPrice.Location = new System.Drawing.Point(22, 159);
            this.labelPrUnitPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrUnitPrice.Name = "labelPrUnitPrice";
            this.labelPrUnitPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrUnitPrice.TabIndex = 3;
            this.labelPrUnitPrice.Text = "単価";
            // 
            // labelPrSaleOf
            // 
            this.labelPrSaleOf.AutoSize = true;
            this.labelPrSaleOf.Location = new System.Drawing.Point(22, 108);
            this.labelPrSaleOf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrSaleOf.Name = "labelPrSaleOf";
            this.labelPrSaleOf.Size = new System.Drawing.Size(43, 13);
            this.labelPrSaleOf.TabIndex = 2;
            this.labelPrSaleOf.Text = "営業所";
            // 
            // labelPrName
            // 
            this.labelPrName.AutoSize = true;
            this.labelPrName.Location = new System.Drawing.Point(22, 61);
            this.labelPrName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrName.Name = "labelPrName";
            this.labelPrName.Size = new System.Drawing.Size(43, 13);
            this.labelPrName.TabIndex = 1;
            this.labelPrName.Text = "商品名";
            // 
            // labelPrID
            // 
            this.labelPrID.AutoSize = true;
            this.labelPrID.Location = new System.Drawing.Point(22, 22);
            this.labelPrID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrID.Name = "labelPrID";
            this.labelPrID.Size = new System.Drawing.Size(42, 13);
            this.labelPrID.TabIndex = 0;
            this.labelPrID.Text = "商品ID";
            // 
            // mProductBindingSource
            // 
            this.mProductBindingSource.DataSource = typeof(携帯会社販売管理システム.Model.Entities.DB.M_Product);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 617);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Products";
            this.Text = "商品管理";
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPr)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker PrDate;
        private System.Windows.Forms.TextBox textBoxPrCode;
        private System.Windows.Forms.TextBox textBoxPrColor;
        private System.Windows.Forms.TextBox textBoxPrNum;
        private System.Windows.Forms.TextBox textBoxPrHidden;
        private System.Windows.Forms.TextBox textBoxPrTotal;
        private System.Windows.Forms.TextBox textBoxPrUnitPrice;
        private System.Windows.Forms.TextBox textBoxPrSaleOf;
        private System.Windows.Forms.TextBox textBoxPrName;
        private System.Windows.Forms.TextBox textBoxPrID;
        private System.Windows.Forms.Label labelPrFlag;
        private System.Windows.Forms.Label labelPrDate;
        private System.Windows.Forms.Label labelPrCode;
        private System.Windows.Forms.Label labelPrColor;
        private System.Windows.Forms.Label labelPrNum;
        private System.Windows.Forms.Label labelPrHidden;
        private System.Windows.Forms.Label labelPrTotal;
        private System.Windows.Forms.Label labelPrUnitPrice;
        private System.Windows.Forms.Label labelPrSaleOf;
        private System.Windows.Forms.Label labelPrName;
        private System.Windows.Forms.Label labelPrID;
        private System.Windows.Forms.ComboBox comboBoxPrFlag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btPrList;
        private System.Windows.Forms.Button btPrUpdate;
        private System.Windows.Forms.Button btPrRegistration;
        private System.Windows.Forms.Button btPrRearch;
        private System.Windows.Forms.DataGridView dataGridViewPr;
        private System.Windows.Forms.BindingSource mProductBindingSource;
    }
}