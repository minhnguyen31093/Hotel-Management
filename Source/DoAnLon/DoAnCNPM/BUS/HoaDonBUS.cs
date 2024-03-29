using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    public static class HoaDonBUS
    {
        public static bool ThemHD(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.ThemHD(hdDTO);
        }

        public static bool ThemCT(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.ThemCT(hdDTO);
        }

        public static bool XoaHD(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.XoaHD(hdDTO);
        }

        public static string LayMaHDTuDong(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayMaHDTuDong(hdDTO);
        }

        public static DataSet LayDanhSachHD(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayDanhSachHD(hdDTO);
        }

        public static DataSet LayDanhSachKH(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayDanhSachKH(hdDTO);
        }

        public static DataSet LayDanhSachNV(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayDanhSachNV(hdDTO);
        }

        public static DataSet LayDanhSachPhong(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayDanhSachPhong(hdDTO);
        }

        public static string LayLoaiPhong(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayLoaiPhong(hdDTO);
        }

        public static string LayLoaiKhach(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayLoaiKhach(hdDTO);
        }

        public static string LayGiaVNPhong(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayGiaVNPhong(hdDTO);
        }

        public static string LayHeSo(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayHeSo(hdDTO);
        }

        public static string LayTyLePhuThuMax(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayTyLePhuThuMax(hdDTO);
        }

        public static string LayTyLePhuThuMin(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayTyLePhuThuMin(hdDTO);
        }

        public static DataSet LayThongTinHoaDon(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayThongTinHoaDon(hdDTO);
        }

        public static string LayTenKhachHang(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayTenKhachHang(hdDTO);
        }

        public static string LayTenNhanVien(HoaDonDTO hdDTO)
        {
            return HoaDonDAO.LayTenNhanVien(hdDTO);
        }
    }
}
