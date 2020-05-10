using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BaiThiCuoiKy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<TaiLieu> taiLieuList = new List<TaiLieu>();
        List<TapChi> tapChiList = new List<TapChi>();
        List<Sach> sachList = new List<Sach>();
        List<string> imgList = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmbTheLoai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChuaChonTheLoai.Visibility = Visibility.Hidden;
            if (cmbTheLoai.SelectedIndex == 0)
            {
                txtTenTacGia.Visibility = Visibility.Visible;
                txbTenTacGia.Visibility = Visibility.Visible;
                txtSoTrang.Visibility = Visibility.Visible;
                txbSoTrang.Visibility = Visibility.Visible;
                txbChuDe.Visibility = Visibility.Hidden;
                txtChuDe.Visibility = Visibility.Hidden;
                txbGia.Visibility = Visibility.Hidden;
                txtGia.Visibility = Visibility.Hidden;

            }
            else if (cmbTheLoai.SelectedIndex == 1)
            {
                txbChuDe.Visibility = Visibility.Visible;
                txtChuDe.Visibility = Visibility.Visible;
                txbGia.Visibility = Visibility.Visible;
                txtGia.Visibility = Visibility.Visible;
                txtTenTacGia.Visibility = Visibility.Hidden;
                txbTenTacGia.Visibility = Visibility.Hidden;
                txtSoTrang.Visibility = Visibility.Hidden;
                txbSoTrang.Visibility = Visibility.Hidden;
            }
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát chương trình", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    Close();
                    break;
                case MessageBoxResult.No:
                    break;
            }
        }

        private void btnLamMoi_Click(object sender, RoutedEventArgs e)
        {
            txtMaTaiLieu.Clear();
            txtTenTacGia.Clear();
            txtTenTacGia.Clear();
            txtSoTrang.Clear();
            txtTenTaiLieu.Clear();
            txtChuDe.Clear();
            txtGia.Clear();
            dtpNgayPhatHanh.SelectedDate = null;
            cmbTheLoai.SelectedIndex = -1;
            txtMaTaiLieu.Focus();
        }

        private void btnLuu_Click(object sender, RoutedEventArgs e)
        {
            bool conLoi = false;
            #region Kiểm tra nhập vào
            if (string.IsNullOrEmpty(txtMaTaiLieu.Text))
            {
                ChuaNhapMaTaiLieu.Visibility = Visibility.Visible;
                conLoi = true;
            }
            else
            {
                foreach (TaiLieu tai in taiLieuList.ToList())
                {
                    if (txtMaTaiLieu.Text == tai.maTaiLieu)
                    {
                        if (cmbTheLoai.SelectedIndex == 0)
                        {
                            Sach sach = new Sach();
                            sach.maTaiLieu = txtMaTaiLieu.Text;
                            sach.tenTaiLieu = txtTenTaiLieu.Text;
                            sach.ngayPhatHanh = dtpNgayPhatHanh.SelectedDate.Value;
                            sach.tenTacGia = txtTenTacGia.Text;
                            sach.soTrang = txtSoTrang.Text;
                            sach.theLoai = cmbTheLoai.Text;
                            TaiLieu tai1 = new Sach();
                            tai1 = tai;
                            var sachthe = (Sach)tai1;
                            sachList[sachList.IndexOf(sachthe)] = sach;
                            taiLieuList[taiLieuList.IndexOf(tai)] = sach;

                        }
                        else if (cmbTheLoai.SelectedIndex == 1)
                        {
                            TapChi tapChi = new TapChi();
                            tapChi.maTaiLieu = txtMaTaiLieu.Text;
                            tapChi.tenTaiLieu = txtTenTaiLieu.Text;
                            tapChi.ngayPhatHanh = dtpNgayPhatHanh.SelectedDate.Value;
                            tapChi.theLoai = cmbTheLoai.Text;
                            tapChi.chuDe = txtChuDe.Text;
                            tapChi.Gia = Convert.ToDouble(txtGia.Text);
                            TaiLieu tai1 = new TapChi();
                            tai1 = tai;
                            var tapchithe = (TapChi)tai1;
                            tapChiList[tapChiList.IndexOf(tapchithe)] = tapChi;
                            taiLieuList[taiLieuList.IndexOf(tai)] = tapChi;
                        }
                        #region Xoa
                        txtMaTaiLieu.Clear();
                        txtTenTacGia.Clear();
                        txtTenTacGia.Clear();
                        txtSoTrang.Clear();
                        txtTenTaiLieu.Clear();
                        txtChuDe.Clear();
                        txtGia.Clear();
                        dtpNgayPhatHanh.SelectedDate = null;
                        cmbTheLoai.SelectedIndex = -1;
                        txtMaTaiLieu.Focus();
                        #endregion
                    }
                }
            }
            if (string.IsNullOrEmpty(txtTenTaiLieu.Text))
            {
                ChuaNhapMaTaiLieu.Visibility = Visibility.Visible;
                conLoi = true;
            }
            if (dtpNgayPhatHanh.SelectedDate == null)
            {
                ChuaChonNgayPhatHanh.Visibility = Visibility.Visible;
                conLoi = true;
            }
            if (cmbTheLoai.SelectedIndex == -1)
            {
                ChuaChonTheLoai.Visibility = Visibility.Visible;
                conLoi = true;
            }
            if (cmbTheLoai.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtTenTacGia.Text))
                {
                    ChuaNhapTenTacGia.Visibility = Visibility.Visible;
                    conLoi = true;
                }
                if (string.IsNullOrEmpty(txtSoTrang.Text))
                {
                    ChuaNhapSoTrang.Visibility = Visibility.Visible;
                    conLoi = true;
                }
            }
            else if (cmbTheLoai.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtChuDe.Text))
                {
                    ChuaNhapChuDe.Visibility = Visibility.Visible;
                    conLoi = true;
                }
                if (string.IsNullOrEmpty(txtGia.Text))
                {
                    ChuaNhapGia.Visibility = Visibility.Visible;
                    conLoi = true;
                }
            }
            #endregion
            if (!conLoi)
            {
                lvTaiLieu.Items.Clear();
                if (cmbTheLoai.SelectedIndex == 0)
                {
                    Sach sach = new Sach();
                    sach.maTaiLieu = txtMaTaiLieu.Text;
                    sach.tenTaiLieu = txtTenTaiLieu.Text;
                    sach.ngayPhatHanh = dtpNgayPhatHanh.SelectedDate.Value;
                    sach.tenTacGia = txtTenTacGia.Text;
                    sach.soTrang = txtSoTrang.Text;
                    sach.theLoai = cmbTheLoai.Text;
                    sachList.Add(sach);
                    taiLieuList.Add(sach);

                }
                else if (cmbTheLoai.SelectedIndex == 1)
                {
                    TapChi tapChi = new TapChi();
                    tapChi.maTaiLieu = txtMaTaiLieu.Text;
                    tapChi.tenTaiLieu = txtTenTaiLieu.Text;
                    tapChi.ngayPhatHanh = dtpNgayPhatHanh.SelectedDate.Value;
                    tapChi.theLoai = cmbTheLoai.Text;
                    tapChi.chuDe = txtChuDe.Text;
                    tapChi.Gia = Convert.ToDouble(txtGia.Text);
                    tapChiList.Add(tapChi);
                    taiLieuList.Add(tapChi);

                }
                txtMaTaiLieu.Clear();
                txtTenTacGia.Clear();
                txtTenTacGia.Clear();
                txtSoTrang.Clear();
                txtTenTaiLieu.Clear();
                txtChuDe.Clear();
                txtGia.Clear();
                dtpNgayPhatHanh.SelectedDate = null;
                cmbTheLoai.SelectedIndex = -1;
                txtMaTaiLieu.Focus();
            }
            foreach (TaiLieu taiLieu in taiLieuList)
            {
                lvTaiLieu.Items.Add(taiLieu);
            }

        }
        #region Đống TextChanged
        private void txtMaTaiLieu_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapMaTaiLieu.Visibility = Visibility.Hidden;
        }

        private void txtTenTaiLieu_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapTenTacGia.Visibility = Visibility.Hidden;
        }

        private void dtpNgayPhatHanh_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            ChuaChonNgayPhatHanh.Visibility = Visibility.Hidden;
        }

        private void txtSoTrang_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapSoTrang.Visibility = Visibility.Hidden;
        }

        private void txtGia_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapGia.Visibility = Visibility.Hidden;
        }

        private void txtChuDe_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapChuDe.Visibility = Visibility.Hidden;
        }

        private void txtTenTacGia_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapTenTacGia.Visibility = Visibility.Hidden;
        }
        #endregion

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            ThongKe thongKeWindow = new ThongKe(tapChiList, sachList);
            thongKeWindow.Show();
        }

        private void BtnXoa_Click_1(object sender, RoutedEventArgs e)
        {
            if (lvTaiLieu.SelectedItems == null)
            {
                MessageBox.Show("Bạn chưa chọn nội dung để xóa", "CHỌN NỘI DUNG", MessageBoxButton.OK);
            }
            else
            {
                MessageBoxResult ret = MessageBox.Show("Bạn muốn xóa ?", "Hỏi xóa ", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (ret == MessageBoxResult.No)
                    return;
                else
                {
                    foreach (TaiLieu tailieu in lvTaiLieu.SelectedItems)
                    {
                        if (tailieu.theLoai=="Tạp chí")
                        {
                            TaiLieu tai = new TapChi();
                            tai = tailieu;
                            var tapchi = (TapChi)tai;
                            tapChiList.Remove(tapchi);
                        }
                        if (tailieu.theLoai == "Sách")
                        {
                            TaiLieu tai1 = new Sach();
                            tai1 = tailieu;
                            var sach = (Sach)tai1;
                            sachList.Remove(sach);
                        }
                        
                        taiLieuList.RemoveAt(taiLieuList.IndexOf(tailieu));
                    }
                    lvTaiLieu.Items.Clear();
                    foreach (TaiLieu tailieu in taiLieuList)
                    {
                        lvTaiLieu.Items.Add(tailieu);
                    }
                }
            }
        }

        private void BtnSapXep_Click(object sender, RoutedEventArgs e)
        {
                lvTaiLieu.Items.Clear();
                taiLieuList.Sort(new TaiLieu());
                foreach (TaiLieu tailieu in taiLieuList)
                {
                    lvTaiLieu.Items.Add(tailieu);
                }
            
        }
            private void LvTaiLieu_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                if (e.AddedItems.Count == 0)
                    return;
                else
                {
                    TaiLieu tl = e.AddedItems[0] as TaiLieu;
                    txtTenTaiLieu.Text = tl.tenTaiLieu;
                    txtMaTaiLieu.Text = tl.maTaiLieu;
                    cmbTheLoai.Text = tl.theLoai;
                    if (cmbTheLoai.Text == "Sách")
                    {
                        Sach sach1 = e.AddedItems[0] as Sach;
                        txtTenTacGia.Text = sach1.tenTacGia;
                        txtSoTrang.Text = sach1.soTrang;
                    }
                    if (cmbTheLoai.Text == "Tạp chí")
                    {
                        TapChi tc1 = e.AddedItems[0] as TapChi;
                        txtChuDe.Text = tc1.chuDe;
                        txtGia.Text = tc1.Gia.ToString();
                    }

                }
            }
    }
}