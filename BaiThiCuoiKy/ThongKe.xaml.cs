using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BaiThiCuoiKy
{
    /// <summary>
    /// Interaction logic for ThongKe.xaml
    /// </summary>
    public partial class ThongKe : Window
    {
        List<TapChi> tapchiList = new List<TapChi>();
        List<Sach> sachList = new List<Sach>();
        public ThongKe(List<TapChi> tclist, List<Sach> slist)
        {
            InitializeComponent();
            tapchiList = new List<TapChi>(tclist);
            sachList = new List<Sach>(slist);
            foreach (TapChi tapChi in tapchiList)
            {
                lvTapChi.Items.Add(tapChi);
            }
            txbSoSach.Text = sachList.Count.ToString() + " tài liệu";
            txbSoTapChi.Text = tapchiList.Count.ToString() + " tài liệu";
            foreach (Sach sach in sachList)
            {
                lvSach.Items.Add(sach);
            }

        }
        
    }
}
