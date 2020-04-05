using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class QuanLyKhachSan : Form
    {
        SqlConnection con;// Khai báo đối tượng kết nối
        DataTable tablePhong; //Đối tượng lưu bảng Phòng
        public QuanLyKhachSan()
        {
            InitializeComponent();
        }

        private void QuanLyKhachSan_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();// Khởi tạo đối tượng
            string connectionString = "Data Source=DESKTOP-UH0D2FE\\SQLEXPRESS01;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
            con.ConnectionString = connectionString;
            con.Open();
            loadDataToGridview();
        }
        public void Disconnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();//đóng kết nối
                con.Dispose();//hủy
                con = null;
            }
        }
        private void loadDataToGridview()
        {
            string sql = "select * from Phong";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);// Đối tượng DataAdapter
            tablePhong = new DataTable();
            adp.Fill(tablePhong);// Đổ dữ liệu từ DataAdapter vào bảng
            dataGridView_Phong.DataSource = tablePhong;
        }

        private void dataGridView_Phong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaphong.Text = dataGridView_Phong.CurrentRow.Cells["MaPhong"].Value.ToString();
            txttenphong.Text = dataGridView_Phong.CurrentRow.Cells["TenPhong"].Value.ToString();
            txtdongia.Text = dataGridView_Phong.CurrentRow.Cells["DonGia"].Value.ToString();

            txtmaphong.Enabled = false;
           
        }
        private void ResetValues()
        {
            txtmaphong.Text = "";
            txttenphong.Text = "";
            txtdongia.Text = "";
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntThem.Enabled = false;
            bntSua.Enabled = false;
            BntXoa.Enabled = false;
            bntLuu.Enabled = true;
            bntHuy.Enabled = true;
            txtmaphong.Enabled = true;
            txtmaphong.Focus();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT MaPhong FROM Phong WHERE MaPhong='" + txtmaphong.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable tablePhong = new DataTable();
            adp.Fill(tablePhong);
            if (tablePhong.Rows.Count > 0)
            { 
                MessageBox.Show("Mã phòng đã tồn tại"); 
                return;
            }
            if (txtmaphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã phòng", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmaphong.Focus();
                return;
            }
            if (txttenphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên phòng","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txttenphong.Focus();
                return;
            }
            if(txtdongia.Text=="")
            {
                MessageBox.Show("Bạn cần nhập đơn giá","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            else
            {
                sql = "insert into Phong values('"+ txtmaphong.Text + "','" + txttenphong.Text + "'";
                if (txtdongia.Text != "")
                    sql = sql + "," + txtdongia.Text.Trim();
                sql = sql + ")";
                
                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    loadDataToGridview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                return;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmaphong.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "Delete from Phong where MaPhong='" + txtmaphong.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                loadDataToGridview();
                ResetValues();
            }
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            string sql = "Update Phong set TenPhong='"+txttenphong.Text+"',DonGia='"+txtdongia.Text+"'" +
                "where MaPhong='"+txtmaphong.Text+"' ";
            if (txttenphong.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn cần nhập tên phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenphong.Focus();
                return;
            }
            if (txtdongia.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtdongia.Focus();
                return;
            }
            txtmaphong.Enabled = false;
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            loadDataToGridview();
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            bntThem.Enabled = true;
            bntSua.Enabled = true;
            BntXoa.Enabled = true;
            bntHuy.Enabled = false;
            bntLuu.Enabled = false;
            txtmaphong.Enabled = false;
        }
        
        private void bntThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi chương trình không?","Thông báo"
                ,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
            con.Close();
            this.Close();
        }

        private void txtdongia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
            (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

    }
}
