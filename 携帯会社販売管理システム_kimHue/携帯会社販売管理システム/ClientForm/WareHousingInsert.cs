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


        public WareHousingInsert(String moveType)
        {
            InitializeComponent();

            this.SwichMode(moveType);
        }
        public WareHousingInsert(String moveType, DataTable displayData)
        {
            InitializeComponent();

            this.SwichMode(moveType);
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
                    break;

                case MOVE_TYPE_02:
                    lblTittle.Text = MOVE_TYPE_NAME_02;
                    txtUserName.Text = UserName;
                    txtUserName.Visible = true;
                    txtUserName.Enabled = false;
                    break;

                default:
                    break;
            }
        }

    }
}
