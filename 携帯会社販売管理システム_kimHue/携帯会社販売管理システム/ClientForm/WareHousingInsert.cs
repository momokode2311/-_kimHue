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

    public partial class WareHousingInsert : BaseForm
    {
        const string MOVE_TYPE_01 = "Insert"; //登録モード
        const string MOVE_TYPE_02 = "Modify"; //更新・削除モード

        const string MOVE_TYPE_NAME_01 = "入庫情報登録"; //登録モード
        const string MOVE_TYPE_NAME_02 = "入庫情報更新"; //更新・削除モード

        private string Move_Type { get;set; }

        public WareHousingInsert(string moveType, string whNumber, string whDate)
        {
            InitializeComponent();

            this.Move_Type = moveType;
            this.SwichMode(moveType);


            txtWHSNo.Text = whNumber.Trim();
            txtDt.Text = whDate.Trim();

            SearchWHDetailData(whNumber, whDate);

        }

        private void SwichMode(string moveType)
        {
            switch (moveType)
            {
                case MOVE_TYPE_01:
                    lblTittle.Text = MOVE_TYPE_NAME_01;
                    txtUserName.Text = UserName;
                    txtUserName.Visible = true;
                    txtUserName.Enabled = false;

                    btnExecute.Text = "登録";
                    btnDelete.Visible = false;
                    
                    break;

                case MOVE_TYPE_02:
                    lblTittle.Text = MOVE_TYPE_NAME_02;
                    txtUserName.Text = UserName;
                    txtUserName.Visible = true;
                    txtUserName.Enabled = false;

                    btnExecute.Text = "更新";
                    btnDelete.Visible = true;
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// 移動タイプが更新の場合、対象データを取得する
        /// </summary>
        /// <param name="whNo"></param>
        /// <param name="whDate"></param>
        private void SearchWHDetailData(string whNo, string whDate)
        {
            try
            {
                var dtAccess = new WareHousingDataAccess();

                var dt = dtAccess.GetWareHousingModifyData(whNo,whDate);
                
                grvWareHousingInsert.DataSource = dt;


                grvWareHousingInsert.Columns["WaID"].HeaderText = "入荷番号";
                grvWareHousingInsert.Columns["WaID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grvWareHousingInsert.Columns["WaDate"].HeaderText = "入荷日";
                grvWareHousingInsert.Columns["WaDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grvWareHousingInsert.Columns["PrID"].HeaderText = "商品コード";
                grvWareHousingInsert.Columns["PrID"].Width = 100;
                grvWareHousingInsert.Columns["PrName"].HeaderText = "商品名称";
                grvWareHousingInsert.Columns["PrName"].Width = 140;
                grvWareHousingInsert.Columns["PrName"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grvWareHousingInsert.Columns["Color"].HeaderText = "色";
                grvWareHousingInsert.Columns["Color"].Width = 100;
                grvWareHousingInsert.Columns["Price"].HeaderText = "単価";
                grvWareHousingInsert.Columns["Price"].Width = 80;
                grvWareHousingInsert.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grvWareHousingInsert.Columns["WDquantity"].HeaderText = "入荷数量";
                grvWareHousingInsert.Columns["WDquantity"].Width = 80;
                grvWareHousingInsert.Columns["WDquantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grvWareHousingInsert.Columns["Mnumber"].Visible = false;
                grvWareHousingInsert.Columns["TotalAmount"].HeaderText = "合計金額";
                grvWareHousingInsert.Columns["TotalAmount"].Width = 120;
                grvWareHousingInsert.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            switch (Move_Type)
            {
                case MOVE_TYPE_01:
                    //TODO: Insert
                    break;

                case MOVE_TYPE_02:
                    //TODO: Update
                    break;
            }
        }

        private void WareHousingInsert_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO: Hien thi data da update tai form 入荷照会
            CallForm(this, new WareHousing(), ClientId.Form_004, ClientId.Form_004_01);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TODO: Hien thi data da update tai form 入荷照会
            CallForm(this, new WareHousing(), ClientId.Form_004, ClientId.Form_004_01);
        }
    }
}
