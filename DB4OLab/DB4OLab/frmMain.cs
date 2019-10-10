using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB4OLab
{
    public partial class frmMain : Form
    {
        IObjectContainer Database = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Student sv = new Student
            {
                StudentId = txtMaSV.Text,
                FullName = txtHoTen.Text,
                Mark = double.Parse(txtDiem.Text),
                RegisterYear = int.Parse(txtNamNhapHoc.Text),
                BirthDate = dtpNgaySinh.Value
            };

            DBHelper.InsertObject<Student>(sv);
        }


        private void frmMain_Load(object sender, EventArgs e)
        {
            DBHelper.OpenDatabase();
            Database = DBHelper.Database;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DBHelper.CloseDatabase();
        }
    }
}
