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

namespace QuanLiThuVien
{
    public partial class frmNhanVien : Form
    {
        SqlConnection con;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        void ThemNV (ListView lvw)
        {

            //ListViewItem list = new ListViewItem();
            //list.Text = txtTen.Text;
            //list.SubItems.Add(txtMS.Text);
            //list.SubItems.Add(txtChucvu.Text);
            //if (rdbNam.Checked == true)
            //    list.SubItems.Add(rdbNam.Text);
            //else
            //    list.SubItems.Add(rdbNu.Text);
            //list.SubItems.Add(txtCMND.Text);
            //list.SubItems.Add(dtpNgaySinh.Text);
            //list.ImageIndex = 0;
            //lvw.Items.Add(list);


        }
        public void connectDatabase(out SqlConnection con)
        {

            string strConnect = @"Data Source=DESKTOP-F9169B5\SQLEXPRESS;Initial Catalog=Quanlycuuhang;Integrated Security=True;";
            con = new SqlConnection(strConnect);
            
            if (con.State == ConnectionState.Closed)
                con.Open();
            //B3 Thực thi các câu lệch sql

        }
      
        public void addNcc(SqlConnection con)
        {
            
            string sqlQuery = string.Format(
      "INSERT INTO NHACUNGCAP(MANCC,TEN,WEBSITE,EMAIL,XOA,GHICHU) VALUES('{0}',N'{1}','{2}','{3}',0,'')",
      
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            int NumofRow = cmd.ExecuteNonQuery();
            if (NumofRow > 0)
            {
                MessageBox.Show("Bạn đã thêm thành công ");

            }
            else
                MessageBox.Show("Lỗi thêm mới !");
            con.Close();

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
           
            
            connectDatabase(out con);
            addNhanvien(con);
            
           
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {


            string strConnect = @"Data Source=DESKTOP-F9169B5\SQLEXPRESS;Initial Catalog=Quanlycuahang;Integrated Security=True;";
            SqlConnection con = new SqlConnection(strConnect);
            if (con.State == ConnectionState.Closed)
                con.Open();
            //Show dữ liệu ra bảng 
            string sSelectNhanVien = @"Select * FROM NHACUNGCAP";
            SqlCommand cmdNhanvien = new SqlCommand(sSelectNhanVien, con);
            SqlDataReader dtr = cmdNhanvien.ExecuteReader();

            DataTable dtNhanvien = new DataTable();
            dtNhanvien.Load(dtr);

            dgvDSNhanVien.DataSource = dtNhanvien;

            con.Close();
        }

        private void bntXoaNv_Click(object sender, EventArgs e)
        {
            connectDatabase(out con);

            string sDeleteNhanvien = string.Format(@"Delete NHANVIEN WHERE MANV = '{0}'", txtMS.Text);
            SqlCommand cmd = new SqlCommand(sDeleteNhanvien, con);
            int NumofRow = cmd.ExecuteNonQuery();
            if (NumofRow > 0)
            {
                MessageBox.Show("Bạn đã thêm thành công ");

            }
            else
                MessageBox.Show("Lỗi thêm mới !");
            con.Close();
        }
    }
}
