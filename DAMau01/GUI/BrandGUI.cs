using DAMau01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAMau01.Data;

namespace DAMau01.GUI
{
    public partial class BrandGUI : Form
    {
        BrandBLL brandBLL = new BrandBLL();
        public BrandGUI()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BrandGUI_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = brandBLL.getAllBrand() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            bool status = true;
            if (rbHoatDong.Checked == false && rbDung.Checked == false)
            {
                MessageBox.Show("Hãy chọn trạng thái");
            }
            else
            {
                Brand b = new Brand()
                {
                    ID = int.Parse(txtID.Text),
                    BrandName = txtName.Text,
                    Description = int.Parse(txtNam.Text),
                    Status = rbHoatDong.Checked ? true : false
                };

                MessageBox.Show(brandBLL.SaveBrand(b));
            }

        }
    }
}
