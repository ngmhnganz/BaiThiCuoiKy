using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCuoiKy
{
    public class TaiLieu
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
        
    }
}
