using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HepsigidiyorOOP_Example
{
    public partial class OrderHistoryForm : Form
    {
        public OrderHistoryForm()
        {
            InitializeComponent();
        }

        public object MasterOrders { get; private set; }

        private void OrderHistoryForm_Load(object sender, EventArgs e)
        {
            grdHistory.DataSource = null;
            grdHistory.DataSource = FakeDb.Database.MasterOrders;
            grdHistory.Columns[0].Visible = false;
            grdHistory.Columns[2].HeaderText = "Tarih";
            grdHistory.Columns[1].HeaderText = "Toplam Tutar";
        }
    }
}
