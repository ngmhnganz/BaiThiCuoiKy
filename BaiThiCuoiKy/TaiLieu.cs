using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCuoiKy
{
    public class TaiLieu
    {
        public string ma { get; set; }
        public string ten { get; set; }
        public DateTime ngayPhatHanh { get; set; }
        public string theLoai { get; set; }
          

        public TaiLieu(string maTaiLieu, string tenTaiLieu, DateTime ngayPhatHanh, string theLoai)
        {
            this.ma = maTaiLieu;
            this.ten = tenTaiLieu;
            this.ngayPhatHanh = ngayPhatHanh;
            this.theLoai = theLoai;
        
        }
        public TaiLieu()
        {

        }
        
    }
}
