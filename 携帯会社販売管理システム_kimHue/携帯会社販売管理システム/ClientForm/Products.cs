using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム
{
    public partial class Products : Form
    {
        InventoryManage inventory = new InventoryManage();
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=Inventory_Control;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Products()
        {
            InitializeComponent();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            
        }
        private void AddBinding()
        {
            textBoxPrID.DataBindings.Add(new Binding("Text", dataGridViewPr.DataSource, "ID"));
            textBoxPrName.DataBindings.Add(new Binding("Text", dataGridViewPr.DataSource, "Name"));
        }

        private void btPrUpdate_Click(object sender, EventArgs e)
        {
            M_Product pr = new M_Product();
            inventory.M_Product.Add(pr);
            inventory.SaveChanges();
        }

        private void btPrRearch_Click(object sender, EventArgs e)
        {
            M_Product pr = new M_Product();
            pr.PrID = textBoxPrID.Text;
            pr.PrName = textBoxPrName.Text;

        }
        
        private void btPrList_Click(object sender, EventArgs e)
        {
            //M_Product テブールを表示する
            //var query = inventory.M_Product;
            //dataGridViewPr.DataSource = query.ToList();
            //Linqで使う
            var query = from pr in inventory.M_Product
                        select new
                        {
                            商品ID = pr.PrID,
                            商品名 = pr.PrName,
                            営業所 = pr.M_SalesOffice.SOName,
                            商品番号 = pr.Mnumber,
                            カラー名 = pr.Color,
                            商品コード = pr.PrCode,
                            単価 = pr.PrUnitPrice,
                            合計金額 = pr.PrTotal,
                            発売日 = pr.Rdate,
                            グラフ = pr.PDFlag,
                            非常示理由 = pr.PrHidden
                        };
            dataGridViewPr.DataSource = query.ToList();
        }
    }
}
