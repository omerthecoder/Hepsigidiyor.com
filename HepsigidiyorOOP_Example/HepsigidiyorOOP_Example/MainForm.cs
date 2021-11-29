using HepsigidiyorOOP_Example.Entities;
using HepsigidiyorOOP_Example.Repositories;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        ProductRepository PR;
        OrderRepository OR;
        MasterOrderRepository MR;
        int masterorderId = 1;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbProduct.SelectedIndex > -1)
            {
                Order order = new Order();
                Product product = PR.Get()[cmbProduct.SelectedIndex];
                order.Id = (int)this.Tag;
                order.ProductId = product.Id;
                order.MasterOrderId = masterorderId;
                order.ProductCount = nuCount.Value;
                order.OrderPrice = nuCount.Value * product.ProductPrice;
                if ((int)this.Tag==0)
                {
                    OR.Add(order);
                }
                else
                {
                    OR.Update(order);
                    this.Tag = 0;
                }
            }
            ClearControls();
            ListFill();
        }

        private void ClearControls()
        {
            nuCount.Value = 1;
            cmbProduct.SelectedIndex = -1;
        }

        private void ListFill()
        {
            lstBasket.Items.Clear();
            for (int i = 0; i < OR.Get().Count; i++)
            {
                if (OR.Get()[i].MasterOrderId==masterorderId)
                {
                    Order order = OR.Get()[i];
                    lstBasket.Items.Add($"{order.ProductCount} Adet {PR.FindById(order.ProductId)} : {order.OrderPrice}"); 
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PR = new ProductRepository();
            OR = new OrderRepository();
            MR = new MasterOrderRepository();
            ComboFill();
            this.Tag = 0;
        }
        void ComboFill()
        {
            foreach (var product in PR.Get())
            {
                cmbProduct.Items.Add(product.ToString());
            }
        }

        private void btnOrderComplete_Click(object sender, EventArgs e)
        {
            if (lstBasket.Items.Count>0)
            {
                MasterOrder masterOrder = new MasterOrder();
                masterOrder.OrderDate = DateTime.Now.ToString();
                masterOrder.Id = masterorderId;
                decimal totalprice = 0;

                for (int i = 0; i < OR.Get().Count; i++)
                {
                    if (OR.Get()[i].MasterOrderId == masterOrder.Id)
                    {
                        totalprice = totalprice + OR.Get()[i].OrderPrice;
                    }
                }
                masterOrder.TotalPrice = totalprice;
                MR.Add(masterOrder);
                masterorderId++;
                ListFill();
                MessageBox.Show($"Siparişiniz tamamlandı. Toplam tutar: {masterOrder.TotalPrice} TL"); 
            }
        }

        private void lstBasket_DoubleClick(object sender, EventArgs e)
        {
            Order order = OR.Get()[lstBasket.SelectedIndex];
            Product product = PR.FindById(order.ProductId);
            int index = 0;
            for (int i = 0; i < PR.Get().Count; i++)
            {
                if (PR.Get()[i] == product)
                {
                    break;
                }
                index++;
            }
            cmbProduct.SelectedIndex = index;
            nuCount.Value = order.ProductCount;
            this.Tag = order.Id;
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedIndex>-1)
            {
                OR.Delete(OR.Get()[lstBasket.SelectedIndex].Id);
                ListFill();
            }
            
        }

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            OrderHistoryForm ohf = new OrderHistoryForm();
            ohf.ShowDialog();
        }
    }
}
