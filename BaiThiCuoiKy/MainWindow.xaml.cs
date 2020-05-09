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
        List<TaiLieu> taiLieuList = new List<TaiLieu>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cmbTheLoai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChuaChonTheLoai.Visibility = Visibility.Hidden;
            if (cmbTheLoai.SelectedIndex==0)
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
            else if (cmbTheLoai.SelectedIndex==1)
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
                    taiLieuList.Add(sach);

                }
               else if (cmbTheLoai.SelectedIndex == 1)
                {
                    TapChi tapChi = new TapChi();
                    tapChi.maTaiLieu = txtMaTaiLieu.Text;
                    tapChi.tenTaiLieu = txtTenTaiLieu.Text;
                    tapChi.ngayPhatHanh= dtpNgayPhatHanh.SelectedDate.Value;
                    tapChi.theLoai = cmbTheLoai.Text;
                    tapChi.chuDe = txtChuDe.Text;
                    tapChi.Gia = Convert.ToDouble(txtGia.Text);
                    taiLieuList.Add(tapChi);

                }
                foreach (TaiLieu taiLieu in taiLieuList)
                {
                    lvTaiLieu.Items.Add(taiLieu);
                }

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
            ThongKe thongKeWindow = new ThongKe(taiLieuList);
            thongKeWindow.Show();
        }
    }
}
