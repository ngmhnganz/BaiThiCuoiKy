using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiThiCuoiKy
{
    public class TaiLieu
    {
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }
        public DateTime NgayPhatHanh { get; set; }
        public string TheLoai { get; set; }
        public string TenTacGia { get; set; }
        public string SoTrang { get; set; }

        public TaiLieu(string maTaiLieu, string tenTaiLieu, DateTime ngayPhatHanh, string theLoai, string tenTacGia, string soTrang)
        {
            MaTaiLieu = maTaiLieu;
            TenTaiLieu = tenTaiLieu;
            NgayPhatHanh = ngayPhatHanh;
            TheLoai = theLoai;
            TenTacGia = tenTacGia;
            SoTrang = soTrang;
        }
    }
}
