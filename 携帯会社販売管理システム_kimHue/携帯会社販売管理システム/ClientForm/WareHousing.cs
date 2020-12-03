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
                //Goi class thuc hien nhiem vu ket noi bang du lieu
                var dtAccess = new WareHousingDataAccess();
                var dt = dtAccess.GetWareHousingInfo(txtWHSFrom.Text,
                                                     txtWHSTo.Text,
                                                     txtGoodName.Text,
                                                     txtGoodCodeFrom.Text,
                                                     txtGoodCodeTo.Text,
                                                     txtDtFrom.Text,
                                                     txtDtTo.Text,
                                                     cbxUserName.SelectedItem.ToString());

                if (dt.Rows.Count > 0)
                {
                    DisplayMessage(MessageKind.SuccessBox, MessageManager.S001);
                    this.DisplayData(dt);

                }
                else
                {
                    DisplayMessage(MessageKind.ErrorBox, MessageManager.E003);
                }

            }
            catch (Exception ex)
            {
                DisplayMessage(MessageKind.ErrorBox, MessageManager.E000);
                ErrorCatcher(ex.Message);
                throw ex;
            }


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var insertForm = new WareHousingInsert(MOVE_TYPE_01);
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


        }

        /// <summary>
        /// Goi ham xu ly sau khi truyen Data vao Grid view 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grvWareHousingView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //TODO: Chinh sua Cols, hoac logic tai day
        }

        private void dtPickerFrom_ValueChanged(object sender, EventArgs e)
        {
            this.txtDtFrom.Text = this.dtPickerFrom.Value.ToString("yyyy/MM/dd");
        }

        private void dtPickerTo_ValueChanged(object sender, EventArgs e)
        {
            this.txtDtTo.Text = this.dtPickerTo.Value.ToString("yyyy/MM/dd");
        }


        #endregion

    }
}
