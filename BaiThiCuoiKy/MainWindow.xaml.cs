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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnXoa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmbTheLoai_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem) cmbTheLoai.SelectedItem;
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
            if (string.IsNullOrEmpty(txtMaTaiLieu.Text))
            {
                ChuaNhapMaTaiLieu.Visibility = Visibility.Visible;
            }
            if (string.IsNullOrEmpty(txtTenTaiLieu.Text))
            {
                ChuaNhapMaTaiLieu.Visibility = Visibility.Visible;
            }

        }

        private void txtMaTaiLieu_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChuaNhapMaTaiLieu.Visibility = Visibility.Hidden;
        }
    }
}
