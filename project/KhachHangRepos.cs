using project.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class KhachHangRepos
    {
        private List<KhachHangViewModel> lst;

        public KhachHangRepos()
        {
            using (QuanLyBanHangSieuThiFullEntities db = new QuanLyBanHangSieuThiFullEntities())
            {
                lst = new List<KhachHangViewModel>();
                lst = (from c in db.CHITIETHOADONs
                       select new KhachHangViewModel
                       {
                           MaKhachHang = c.HOADON.Makhachhang,
                           TenSanPham = c.SANPHAM.Tensanpham,
                           MaSanPham = c.Masanpham,
                           GiaBan = c.SANPHAM.Giaban,
                           SoLuongBan = c.Soluongban,
                           ThanhTien = c.Thanhtien
                       }).ToList();
            }
        }

        public List<KhachHangViewModel> GetAll()
        {
            return lst;
        }
    }
}
