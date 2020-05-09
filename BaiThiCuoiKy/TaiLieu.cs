using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCuoiKy
{
    public class TaiLieu:IComparer<TaiLieu>
    {
        public string maTaiLieu { get; set; }
        public string tenTaiLieu { get; set; }
        public DateTime ngayPhatHanh { get; set; }
        public string theLoai { get; set; }
          

        public TaiLieu(string maTaiLieu, string tenTaiLieu, DateTime ngayPhatHanh, string theLoai)
        {
            this.maTaiLieu = maTaiLieu;
            this.tenTaiLieu = tenTaiLieu;
            this.ngayPhatHanh = ngayPhatHanh;
            this.theLoai = theLoai;
        
        }
        public TaiLieu()
        {

        }
        public int Compare(TaiLieu x, TaiLieu y)
        {
            int kq= x.ngayPhatHanh.CompareTo(y.ngayPhatHanh);
            if (kq == 0)
            {
                return x.maTaiLieu.CompareTo(y.maTaiLieu);
            }
            return kq;
        }
       
    }
}
