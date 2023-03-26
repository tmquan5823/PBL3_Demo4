using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Demo4
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void btn_ThietLapTK_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
            lbl_form.Text = "Thiết lập tài khoản";
            UCThietLapTaiKhoan uc = new UCThietLapTaiKhoan();
            panel_main.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }
    }
}
