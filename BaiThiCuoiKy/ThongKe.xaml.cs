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
    public partial class ThongKe : MainWindow
    {
        List<TaiLieu> taiLieuList = new List<TaiLieu>();
        public ThongKe(List<TaiLieu> list)
        {
            InitializeComponent();
            taiLieuList = new List<TaiLieu>(list);

        }
    }
}
