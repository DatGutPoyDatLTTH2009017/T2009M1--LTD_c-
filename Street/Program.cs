using System;
using System.Text;
using duongsinh2.entity;
using duongsinh2.view;

namespace duongsinh2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            StreetView streetView = new StreetView();
            streetView.ShowMenu();
        }
    }
}