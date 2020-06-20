using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace UDGD_CK
{
    
    public partial class Form1 : Form
    {
        public static string strname;
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conect = new SqlConnection(@"Data Source=.;Initial Catalog=QLNhanSu;Integrated Security=True");
        
        

        private void ketnoi()
        {
            
            string sql = "select * from NhanVien as NV,ThanNhan where NV.thanNhan_nv= ThanNhan.maTN";
            SqlCommand com = new SqlCommand(sql, conect);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dgriv.DataSource = dt;

            

        }
        private void ketnois()
        {
            
            string sql = "select * from ChamCong";
            SqlCommand com = new SqlCommand(sql, conect);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            dgv_chamcong.DataSource = dt;
            
        }
        private void hienthitext()
        {
            //group first
            txt_manv.DataBindings.Clear();
            txt_manv.DataBindings.Add("Text", dgriv.DataSource, "maNV");
            txt_hoten.DataBindings.Clear();
            txt_hoten.DataBindings.Add("Text", dgriv.DataSource, "tenNV");
            cb_pb.DataBindings.Clear();
            cb_pb.DataBindings.Add("Text", dgriv.DataSource, "phong");
            date_birth.DataBindings.Clear();
            date_birth.DataBindings.Add("Text", dgriv.DataSource, "ngaySinh");
            txt_thannhan.DataBindings.Clear();
            txt_thannhan.DataBindings.Add("Text", dgriv.DataSource, "ten_TN");
            cb_cv.DataBindings.Clear();
            cb_cv.DataBindings.Add("Text", dgriv.DataSource, "chucVu");
            cb_honnhan.DataBindings.Clear();
            cb_honnhan.DataBindings.Add("Text", dgriv.DataSource, "honNhan");
            //group second
            txt_diachi.DataBindings.Clear();
            txt_diachi.DataBindings.Add("Text", dgriv.DataSource, "diaChi");
            txt_cmnd.DataBindings.Clear();
            txt_cmnd.DataBindings.Add("Text", dgriv.DataSource, "CMND");
            txt_email.DataBindings.Clear();
            txt_email.DataBindings.Add("Text", dgriv.DataSource, "email");
            txt_sdt.DataBindings.Clear();
            txt_sdt.DataBindings.Add("Text", dgriv.DataSource, "sdt");
            txt_thannhan.DataBindings.Clear();
            txt_thannhan.DataBindings.Add("Text", dgriv.DataSource, "ten_TN");
            txt_sdt_nt.DataBindings.Clear();
            txt_sdt_nt.DataBindings.Add("Text", dgriv.DataSource, "sdt_TN");
            txt_quanhe.DataBindings.Clear();
            txt_quanhe.DataBindings.Add("Text", dgriv.DataSource, "quanHe");
            txt_diachiTN.DataBindings.Clear();
            txt_diachiTN.DataBindings.Add("Text", dgriv.DataSource, "diaChi_TN");

            cb_matn.DataBindings.Clear();
            cb_matn.DataBindings.Add("Text", dgriv.DataSource,"thanNhan_nv");
            // group 3
            txt_luong.DataBindings.Clear();
            txt_luong.DataBindings.Add("Text", dgriv.DataSource, "luong");
            date_begin.DataBindings.Clear();
            date_begin.DataBindings.Add("Text", dgriv.DataSource, "ngayBD");

            if (rb_work.Checked == true)
            {
                date_retire.Enabled = false;
            }
            else
            {
                date_retire.Enabled = true;
            }
            date_retire.DataBindings.Clear();
            date_retire.DataBindings.Add("Text", dgriv.DataSource,"ngayNV");
            // Tab cham cong

            cb_ma.DataBindings.Clear();
            cb_ma.DataBindings.Add("Text", dgv_chamcong.DataSource, "maNV_cc");


            cb_ten.DataBindings.Clear();
            cb_ten.DataBindings.Add("Text", dgv_chamcong.DataSource, "tenNV_cc");

            datatime_work.DataBindings.Clear();
            datatime_work.DataBindings.Add("Text", dgv_chamcong.DataSource, "ngay_cc");


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }

        private void lb_nt_Click(object sender, EventArgs e)
        {

        }

        private void dgriv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tab_thongtin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conect.Open();
            ketnoi();
            ketnois();
            hienthitext();
            
            SqlDataAdapter pick = new SqlDataAdapter("select * from NhanVien", conect);
            DataTable dts = new DataTable();
            pick.Fill(dts);
            pick.Dispose();
            //
            
            cb_ten.DataSource = dts;
            cb_ten.DisplayMember = "tenNV";
            cb_ten.ValueMember = "MaNV";

            cb_ma.DataSource = dts;
            cb_ma.DisplayMember = "MaNV";
            cb_ma.ValueMember = "MaNV";

            SqlDataAdapter picks = new SqlDataAdapter("select * from PhongBan", conect);
            DataTable dtss = new DataTable();
            picks.Fill(dtss);
            picks.Dispose();
            cb_pb.DataSource = dtss;
            cb_pb.DisplayMember = "maPB";
            cb_pb.ValueMember = "maPB";

            SqlDataAdapter pickss = new SqlDataAdapter("select * from ThanNhan", conect);
            DataTable dtsss = new DataTable();
            pickss.Fill(dtsss);
            pickss.Dispose();

            cb_matn.DataSource = dtsss;
            cb_matn.DisplayMember = "maTN";
            cb_matn.ValueMember = "maTN";

            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

        }

        private void dgriv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgriv.CurrentCell.RowIndex;
            if (dgriv.Rows[t].Cells["gioiTinh"].Value.ToString() == "Nam")
                rd_nam.Checked = true;
            else if(dgriv.Rows[t].Cells["gioiTinh"].Value.ToString() == "Nu")
                rd_nu.Checked = true;
            else
            {
                rd_nam.Checked = false;
                rd_nu.Checked = false;

            }
            //
            if (dgriv.Rows[t].Cells["tinhTrang"].Value.ToString() == "Dang Lam")
                rb_work.Checked = true;
            else if (dgriv.Rows[t].Cells["tinhTrang"].Value.ToString() == "Da Nghi")
                rb_endwork.Checked = true;
            else
            {
                rb_work.Checked = true;
                rb_endwork.Checked = false;

            }
            if (dgriv.Rows[t].Cells["ngayNV"].Value.ToString() != "")
            {
                date_retire.DataBindings.Clear();
                date_retire.DataBindings.Add("Text", dgriv.DataSource, "ngayNV");
            }
            else
                date_retire.DataBindings.Clear();

            if (rb_work.Checked == true)
            {
                date_retire.Enabled = false;
            }
            else
            {
                date_retire.Enabled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.No) e.Cancel = true;

            conect.Close();
            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ketnois();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsua = "UPDATE NhanVien SET tenNV=@tenNV,chucVu=@chucVu , phong = @phong, gioiTinh =@gioiTinh, tinhTrang=@tinhTrang,luong=@luong, diaChi=@diaChi, CMND=@CMND,sdt=@sdt,email=@email,thanNhan_nv=@thanNhan_nv, ngayBD=@ngayBD, ngayNV=@ngayNV where MaNV=@MaNV";
                SqlCommand cmd = new SqlCommand(sqlsua, conect);
                cmd.Parameters.AddWithValue("chucVu", cb_cv.Text);
                cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
                cmd.Parameters.AddWithValue("tenNV", txt_hoten.Text);
                cmd.Parameters.AddWithValue("phong", cb_pb.Text);
                if (rd_nam.Checked == true)
                {
                    cmd.Parameters.AddWithValue("gioiTinh", "Nam");
                }
                else
                {
                    cmd.Parameters.AddWithValue("gioiTinh", "Nu");
                }
                if (rb_work.Checked == true)
                {

                    cmd.Parameters.AddWithValue("tinhTrang", "Dang Lam");

                }
                else
                {
                    cmd.Parameters.AddWithValue("tinhTrang", "Da Nghi");

                }
                cmd.Parameters.AddWithValue("luong", txt_luong.Text);
                cmd.Parameters.AddWithValue("diaChi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("CMND", txt_cmnd.Text);
                cmd.Parameters.AddWithValue("sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                cmd.Parameters.AddWithValue("thanNhan_nv", cb_matn.Text);
                cmd.Parameters.AddWithValue("ngayBD", date_begin.Value);
                cmd.Parameters.AddWithValue("ngayNV", date_retire.Value);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Nhap sai cai gi roi!!!!");
            }
            ketnoi();
            hienthitext();
            

        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            ketnoi();
            hienthitext();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sqldelete = "DELETE from NhanVien where MaNV='" + txt_manv.Text + "'";
                SqlCommand cmd = new SqlCommand(sqldelete, conect);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ban khong the nhan vien co Chuc Vi cap cao!");
            }
            ketnoi();
            hienthitext();
            
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {

                string sqlthem = "Insert into NhanVien (MaNV,ngaySinh, tenNV, chucVu,phong, gioiTinh, tinhTrang,luong,diaChi, CMND,sdt,email,thanNhan_nv,ngayBD,ngayNV)  values (@MaNV,@ngaySinh, @tenNV, @chucVu,@phong, @gioiTinh, @tinhTrang,@luong,@diaChi, @CMND,@sdt,@email, @thanNhan,@ngayBD,@ngayNV)  ";
                SqlCommand cmd = new SqlCommand(sqlthem, conect);
                cmd.Parameters.AddWithValue("chucVu", cb_cv.Text);
                cmd.Parameters.AddWithValue("MaNV", txt_manv.Text);
                cmd.Parameters.AddWithValue("tenNV", txt_hoten.Text);
                cmd.Parameters.AddWithValue("phong", cb_pb.Text);
                if (rd_nam.Checked == true)
                {
                    cmd.Parameters.AddWithValue("gioiTinh", "Nam");
                }
                else
                {
                    cmd.Parameters.AddWithValue("gioiTinh", "Nu");
                }
                if (rb_work.Checked == true)
                {
                    cmd.Parameters.AddWithValue("tinhTrang", "Dang Lam");
                }
                else
                {
                    cmd.Parameters.AddWithValue("tinhTrang", "Da Nghi");
                }
                cmd.Parameters.AddWithValue("luong", txt_luong.Text);
                cmd.Parameters.AddWithValue("diaChi", txt_diachi.Text);
                cmd.Parameters.AddWithValue("CMND", txt_cmnd.Text);
                cmd.Parameters.AddWithValue("sdt", txt_sdt.Text);
                cmd.Parameters.AddWithValue("email", txt_email.Text);
                cmd.Parameters.AddWithValue("thanNhan", cb_matn.Text);
                cmd.Parameters.AddWithValue("ngayBD", date_begin.Value);
                cmd.Parameters.AddWithValue("ngayNV", date_retire.Value);
                cmd.Parameters.AddWithValue("ngaySinh", date_birth.Value);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Ma nhan vien da ton tai");
            }
            ketnoi();
            hienthitext();
            
        }

        private void cb_ten_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if (cb_timtheo.SelectedIndex==0)
            {            
                        string sqltim = "select * from NhanVien as NV,ThanNhan as TN where TN.maTN = NV.thanNhan_nv And NV.MaNV= '" + txt_timkiem.Text + "'";
                        SqlCommand com = new SqlCommand(sqltim, conect);
                        com.CommandType = CommandType.Text;
                        SqlDataAdapter da = new SqlDataAdapter(com);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgriv.DataSource = dt;     
            }
            else if (cb_timtheo.SelectedIndex == 1)
            {
                string sqltim = "select * from NhanVien as NV,ThanNhan as TN where TN.maTN = NV.thanNhan_nv And NV.tenNV= '" + txt_timkiem.Text + "'";
                SqlCommand com = new SqlCommand(sqltim, conect);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgriv.DataSource = dt;
            }
            else if (cb_timtheo.SelectedIndex == 2)
            {
                string sqltim = "select * from NhanVien as NV,ThanNhan as TN where TN.maTN = NV.thanNhan_nv And NV.chucVu= '" + txt_timkiem.Text + "'";
                SqlCommand com = new SqlCommand(sqltim, conect);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgriv.DataSource = dt;
            }
            else if (cb_timtheo.SelectedIndex == 3)
            {
                string sqltim = "select * from NhanVien as NV,ThanNhan as TN where TN.maTN = NV.thanNhan_nv And NV.phong= '" + txt_timkiem.Text + "'";
                SqlCommand com = new SqlCommand(sqltim, conect);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgriv.DataSource = dt;
            }
            else if (cb_timtheo.SelectedIndex == 4)
            {
                string sqltim = "select * from NhanVien as NV,ThanNhan as TN where TN.maTN = NV.thanNhan_nv And NV.gioiTinh= '" + txt_timkiem.Text + "'";
                SqlCommand com = new SqlCommand(sqltim, conect);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgriv.DataSource = dt;
            }
            else
            {
                ketnoi();
            }





        }

        private void btn_themTN_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.Show();
            ketnoi();
            
        }

        private void btn_lm_Click(object sender, EventArgs e)
        {
            SqlDataAdapter pickss = new SqlDataAdapter("select * from ThanNhan", conect);
            DataTable dtsss = new DataTable();
            pickss.Fill(dtsss);
            pickss.Dispose();

            cb_matn.DataSource = dtsss;
            cb_matn.DisplayMember = "maTN";
            cb_matn.ValueMember = "maTN";
        }

        private void btn_dilam_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlthem = "Insert into ChamCong(maNV_cc,tenNV_cc,ngay_cc,tinhTrang_cc,ghiChu_cc) values (@maNV_cc,@tenNV_cc,@ngay_cc,@tinhTrang_cc,@ghiChu_cc)  ";
                SqlCommand cmd = new SqlCommand(sqlthem, conect);
                cmd.Parameters.AddWithValue("maNV_cc", cb_ma.Text);
                cmd.Parameters.AddWithValue("tenNV_cc", cb_ten.Text);
                cmd.Parameters.AddWithValue("tinhTrang_cc", "Di lam");
                cmd.Parameters.AddWithValue("ngay_cc", datatime_work.Value);
                cmd.Parameters.AddWithValue("ghiChu_cc", txt_ghiChu.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Du lieu ngay cong cua nhan vien da dc nhap!");
            }
            ketnois();

        }

        private void btn_nghi_Click(object sender, EventArgs e)
        {
            string sqldelete = "DELETE from ChamCong where maNV_cc='" + cb_ma.Text + "'"+ "And ngay_cc='"+datatime_work.Value+"'";
            SqlCommand cmd = new SqlCommand(sqldelete, conect);
            cmd.ExecuteNonQuery();
            ketnois();
        }

        private void dgv_chamcong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_suacong_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlsua = "UPDATE ChamCong SET maNV_cc=@maNV_cc, tenNV_cc=@tenNV_cc, ngay_cc=@ngay_cc, tinhTrang_cc=@tinhTrang_cc, ghiChu_cc=@ghiChu_cc";
                SqlCommand cmd = new SqlCommand(sqlsua, conect);
                cmd.Parameters.AddWithValue("maNV_cc", cb_ma.Text);
                cmd.Parameters.AddWithValue("tenNV_cc", cb_ten.Text);
                cmd.Parameters.AddWithValue("ngay_cc", datatime_work.Value);
                cmd.Parameters.AddWithValue("tinhTrang_cc", cb_tt.Text);
                cmd.Parameters.AddWithValue("ghiChu_cc", txt_ghiChu.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Du lieu cham cong da ton tai!");
            }
            ketnoi();
        }

        public string lmit = "0";
        private void btn_dn_Click(object sender, EventArgs e)
        {
            dangnhap frm = new dangnhap();
            frm.data = new dangnhap.gdl(gvl);
            frm.limits = new dangnhap.gdl(glm);
            frm.Show();

            
        }
        public void gvl(string values)
        {
            lb_user.Text = "Xin chao:" + values;
        }

       
        public void glm(string values)
        {
            lmit = values;
            if (Int32.Parse(lmit) > 5)
            {
                btn_xoa.Enabled = true;
                btn_them.Enabled = true;
                btn_sua.Enabled = true;
            }
            else
            {
                btn_xoa.Enabled = false;
                btn_them.Enabled = false;
                btn_sua.Enabled = false;
            }
        }

    }
}
