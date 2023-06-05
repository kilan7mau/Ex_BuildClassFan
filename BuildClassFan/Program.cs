// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");
using System;

namespace BuildClassFan
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*Viết chương trình hiển thị các đối tượng bằng cách gọi phương thức ToString
            Tạo 2 đối tượng Fan
            Đối tượng Fan 1: Gán giá trị lớn nhất cho speed, radius là 10, color là yellow và quạt ở trạng thái bật.
            Đối tượng Fan 2: Gán giá trị trung bình cho speed, radius là 5, color là blue và quạt ở trạng thái tắt*/

            Fan Fan1 = new Fan();
            Fan Fan2 = new Fan();
            Fan1.Speed = Fan.FAST;
            Fan1.Radius = 10;
            Fan1.Color = "yellow";
            Fan1.On = true;
            Fan2.Speed = Fan.MEDIUM;
            Fan2.Radius = 5;
            Fan2.Color = "blue";
            Fan2.On = false;
            Console.WriteLine(Fan1.ToString());
            Console.WriteLine(Fan2.ToString());
        }
    }
}