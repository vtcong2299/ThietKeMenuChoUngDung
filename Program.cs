using System;


namespace ThietKeMenuChoUngDung
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
            Console.WriteLine("Menu");
            Console.WriteLine("1: Ve hinh Tam giac");
            Console.WriteLine("2: Ve hinh Chu nhat");
            Console.WriteLine("3: Ve hinh Vuong");
            Console.WriteLine("0: Exit");
            Console.Write("Nhap vao so thu tu cua hinh muon ve:");
            choice= Int32.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                {
                    Console.WriteLine("*");
                    Console.WriteLine("***");
                    Console.WriteLine("******");
                    Console.WriteLine("********");
                    Console.WriteLine("**********");
                    Console.WriteLine("************");
                    break;
                }
                case 2:
                {
                    Console.WriteLine("****************************");
                    Console.WriteLine("****************************");
                    Console.WriteLine("****************************");
                    Console.WriteLine("****************************");
                    Console.WriteLine("****************************");
                    Console.WriteLine("****************************");
                    break;
                }
                case 3:
                {
                    Console.WriteLine("**************");
                    Console.WriteLine("**************");
                    Console.WriteLine("**************");
                    Console.WriteLine("**************");
                    Console.WriteLine("**************");
                    Console.WriteLine("**************");
                    break;
                }
            }
            }while (choice!=0);
            
            Console.ReadKey();


        }
    }
}