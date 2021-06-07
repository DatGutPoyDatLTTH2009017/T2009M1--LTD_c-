using System;
using duongsinh2.controller;

namespace duongsinh2.view
{
    public class StreetView
    {
        private StreetController _streetController = new StreetController();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Quản lí street: ");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("1.Tạo mới street: ");
                Console.WriteLine("2.Hiển thị danh sách street");
                Console.WriteLine("3.Sủa thông tin street");
                Console.WriteLine("4.Xóa thông tin street");
                Console.WriteLine("5.Thoát chương trình");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Nhập lựa chọn từ 1-5");
                int luachon = Convert.ToInt32(Console.ReadLine());
                switch (luachon)
                {
                    case 1:
                        _streetController.TaoMoiStreet();
                        break;
                    case 2:
                       _streetController.HienThiStreet();
                        break;
                    case 3:
                        _streetController.SuaThongTinStreet();
                        break;
                    case 4:
                        _streetController.XoaThongTinStreet();
                        break;
                    case 5:
                        Console.WriteLine("Bye Bye");
                        break;
                    default:
                        Console.WriteLine("Vui lòng chọn từ 1 --> 5");
                        break;
                }

                if (luachon == 5)
                {
                    break;
                }
            }
        }
    }
}