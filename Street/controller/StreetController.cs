using System;
using System.Collections.Generic;
using duongsinh2.entity;
using duongsinh2.model;

namespace duongsinh2.controller
{
    public class StreetController
    {
        private StreetMoDel _streetMoDel = new StreetMoDel();
        private List<Street> _listStreet = new List<Street>();

        public void TaoMoiStreet()
        {
            Console.WriteLine("Vui lòng thông thông tin street: ");
            var street = new Street();
            Console.WriteLine("Mã street: ");
            var maStreet = Console.ReadLine();
            street.Ma = maStreet;
            Console.WriteLine("Tên street: ");
            var tenStreet = Console.ReadLine();
            street.Ten = tenStreet;
            Console.WriteLine("Mô tả street: ");
            var moTaStreet = Console.ReadLine();
            street.MoTa = moTaStreet;
            Console.WriteLine("Ngày sử dụng street: ");
            var ngaySuDungStreet = Console.ReadLine();
            street.NgaySuDung = Convert.ToDateTime(ngaySuDungStreet);
            Console.WriteLine("Lịch sử street: ");
            var lichSuStreet = Console.ReadLine();
            street.LichSu = lichSuStreet;
            Console.WriteLine("Tên quận street: ");
            var tenQuanStreet = Console.ReadLine();
            street.TenQuan = tenQuanStreet;
            bool result = _streetMoDel.Save(street);
            if (result)
            {
                Console.WriteLine("Tạo mới sinh viên thành công");
            }
            else
            {
                Console.WriteLine("Tạo mới thất bại: ");
            }
        }

        public void HienThiStreet()
        {
            var streets = _streetMoDel.FindAll();
            if (streets.Count == 0)
            {
                Console.WriteLine("Chưa có con đường nào");
            }
            else
            {
                foreach (var street in streets)
                {
                    Console.WriteLine($"Ma: {street.Ma} Ten: {street.Ten} MoTa: {street.MoTa}  LichSu: {street.LichSu} TenQuan: {street.TenQuan}");
                } 
            }
        }
        public void SuaThongTinStreet()
        {
            Console.WriteLine("Vui lòng nhập id cần sửa");
            string id = Console.ReadLine();
            Street street = _streetMoDel.FindById(id);
            if (street != null)
            {
                Console.WriteLine("Tên street");
                var tenStreet = Console.ReadLine();
                street.Ten = tenStreet;
                Console.WriteLine("Mô tả street: ");
                var moTaStreet = Console.ReadLine();
                street.MoTa = moTaStreet;
                Console.WriteLine("Ngày sử dụng street: ");
                var ngaySuDungStreet = Console.ReadLine();
                street.NgaySuDung = Convert.ToDateTime(ngaySuDungStreet);
                Console.WriteLine("Lịch sử street: ");
                var lichSuStreet = Console.ReadLine();
                street.LichSu = lichSuStreet;
                Console.WriteLine("Tên quận street: ");
                var tenQuanStreet = Console.ReadLine();
                street.TenQuan = tenQuanStreet;
                var result = _streetMoDel.Update(id, street);
                if (result)
                {
                    Console.WriteLine("Update thành công");
                }
                else
                {
                    Console.WriteLine("Update k thành công");
                }
            }
        }

        public void XoaThongTinStreet()
        {
            Console.WriteLine("Vui lòng nhập mã street cần xóa");
            string id = Console.ReadLine();
            Street street = new Street();
            street = _streetMoDel.FindById(id);
            if (street != null)
            {
                Console.WriteLine("Bạn có muốn Y/N");
                string luachon = Console.ReadLine();
                if (luachon.ToLower().Equals("y"))
                {
                    _streetMoDel.Delete(id);
                    Console.WriteLine("Xóa thành công");
                }
                else
                {
                    Console.WriteLine("Không tìm thấy id cần xóa");
                }
            }
        }
    }
}