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
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PR = new ProductRepository();
            DummyData dd = new DummyData();
            dd.Seed();
            ComboFill();
            
        }
        void ComboFill()
        {
            foreach (var product in PR.Get())
            {
                cmbProduct.Items.Add(product.ToString());
            }
        }
    }
}
