using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 携帯会社販売管理システム
{
    public partial class WareHousing : BaseForm
    {
        const string MOVE_TYPE_01 = "Insert"; //登録モード
        const string MOVE_TYPE_02 = "Modify"; //更新・削除モード

        #region "初期設定"
        public WareHousing()
        {
            InitializeComponent();
        }
        private void WareHousing_Load(object sender, EventArgs e)
        {
            SetDefaultInput();
        }

        
        private void SetDefaultInput()
        {
            this.txtWHSFrom.Text = string.Empty;
            this.txtGoodName.Text = string.Empty;
            this.txtDtFrom.Text = string.Empty;
            this.txtDtTo.Text = string.Empty;
            this.txtWHSFrom.Focus();
        }


        #endregion


        #region "各ボタン処理"
        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaultInput();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var menu = new Menu();
            CallForm(this, menu, ClientId.Form_004, ClientId.Form_002);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var dtAccess = new WareHousingDataAccess();

                var dt = dtAccess.GetWareHousingInfo(txtWHSFrom.Text,
                                                     txtWHSTo.Text,
                                                     txtGoodName.Text,
                                                     txtGoodCodeFrom.Text,
                                                     txtGoodCodeTo.Text,
                                                     txtDtFrom.Text,
                                                     txtDtTo.Text);

                if (dt.Rows.Count > 0)
                {
                    
                    this.DisplayData(dt);
                    DisplayMessage(MessageKind.SuccessBox, MessageManager.S002);

                }
                else
                {
                    this.DisplayData(dt);
                    DisplayMessage(MessageKind.ErrorBox, MessageManager.E003);
                }

            }
            catch (Exception ex)
            {
                //DisplayMessage(MessageKind.ErrorBox, MessageManager.E000);
                DisplayMessage(MessageKind.ErrorBox, ex.StackTrace.ToString());
                ErrorCatcher(ex.Message);
                throw ex;
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var insertForm = new WareHousingInsert(MOVE_TYPE_01, string.Empty, string.Empty );
            CallForm(this, insertForm, ClientId.Form_004_01, ClientId.Form_004);
        }

        #endregion


        #region "イベントハンドラ"
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        private void DisplayData(DataTable dt)
        {
            grvWareHousingView.Visible = true;
            grvWareHousingView.DataSource = dt;

            grvWareHousingView.Columns["WaID"].HeaderText = "入荷番号";
            grvWareHousingView.Columns["WaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvWareHousingView.Columns["WaDate"].HeaderText = "入荷日";
            grvWareHousingView.Columns["WaDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grvWareHousingView.Columns["PrID"].HeaderText = "商品コード";
            grvWareHousingView.Columns["PrID"].Width = 100;
            grvWareHousingView.Columns["PrName"].HeaderText = "商品名称";
            grvWareHousingView.Columns["PrName"].Width = 140;
            grvWareHousingView.Columns["PrName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grvWareHousingView.Columns["Color"].HeaderText = "色";
            grvWareHousingView.Columns["Color"].Width = 100;
            grvWareHousingView.Columns["Price"].HeaderText = "単価";
            grvWareHousingView.Columns["Price"].Width = 80;
            grvWareHousingView.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grvWareHousingView.Columns["WDquantity"].HeaderText = "入荷数量";
            grvWareHousingView.Columns["WDquantity"].Width = 80;
            grvWareHousingView.Columns["WDquantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            grvWareHousingView.Columns["Mnumber"].Visible = false;
            grvWareHousingView.Columns["TotalAmount"].HeaderText = "合計金額";
            grvWareHousingView.Columns["TotalAmount"].Width = 120;
            grvWareHousingView.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        

        }

        /// <summary>
        /// Goi ham xu ly sau khi truyen Data vao Grid view 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvWareHousingView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            try {

                for (var i = 1; i < grvWareHousingView.Rows.Count; i++)
                {
                    var currentRow = grvWareHousingView.Rows[i];

                    currentRow.Cells["WaID"] = new DataGridViewLinkCell();



                }
            
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        private void dtPickerFrom_ValueChanged(object sender, EventArgs e)
        {
            this.txtDtFrom.Text = this.dtPickerFrom.Value.ToString("yyyy/MM/dd");
        }

        private void dtPickerTo_ValueChanged(object sender, EventArgs e)
        {
            this.txtDtTo.Text = this.dtPickerTo.Value.ToString("yyyy/MM/dd");
        }

        private void WareHousing_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();

            var login = new FormLogin();
            CallForm(this, login, ClientId.Form_001, ClientId.Form_004);
        }




        #endregion

        private void grvWareHousingView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var rIndex = e.RowIndex;
                var rData = grvWareHousingView.Rows[rIndex];

                var whNo = rData.Cells["WaID"].Value.ToString();
                var whDate = rData.Cells["WaDate"].Value.ToString().Substring(0,10);

                //Goi form 入荷登録

                CallForm(this, new WareHousingInsert(MOVE_TYPE_02,whNo,whDate), ClientId.Form_004_01, ClientId.Form_004);

            }

        }
    }
}
