using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCuoiKy
{
    public class TapChi : TaiLieu
    {
        public string chuDe { get; set; }
        public double Gia { get; set; }
        public TapChi(string maTaiLieu, string tenTaiLieu, DateTime ngayPhatHanh, string theLoai,double Gia, string chuDe) : base(maTaiLieu, tenTaiLieu, ngayPhatHanh, theLoai)
        {
        }
        public TapChi()
        {
                
        }
    }
}
