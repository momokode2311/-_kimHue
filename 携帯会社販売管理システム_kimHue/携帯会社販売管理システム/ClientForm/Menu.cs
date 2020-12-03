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
    public partial class Menu : BaseForm
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnGoodsManager_Click(object sender, EventArgs e)
        {
            //Producs form 表示する
            Products products = new Products();
            CallForm(this, products, ClientId.Form_003, ClientId.Form_002);

        }

        private void btnWareHousing_Click(object sender, EventArgs e)
        {
            //
            var WareHousing = new WareHousing();
            CallForm(this, WareHousing, ClientId.Form_004, ClientId.Form_002);

        }

        private void btnWHSOut_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomerMng_Click(object sender, EventArgs e)
        {

        }

        private void btnEmployeeMng_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            CallForm(this, new FormLogin(), ClientId.Form_002, ClientId.Form_001);
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
