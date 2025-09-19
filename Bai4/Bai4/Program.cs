using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ChuyenHeCoSo
{

    public static int ChonHeCoso()
    {
        Console.WriteLine("  1. Binary (base 2)");
        Console.WriteLine("  2. Decimal (base 10)");
        Console.WriteLine("  3. Hexadecimal (base 16)");

        while (true)
        {
            Console.Write("Nhap vao lua chon (1, 2, or 3): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    return 2;
                case "2":
                    return 10;
                case "3":
                    return 16;
                default:
                    Console.WriteLine("Khong hop le");
                    break;
            }
        }
    }    
    public static void Main()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Chon he so nhap vao:");
                int He1 = ChonHeCoso();

                Console.WriteLine("\nChon he so doi:");
                int He2 = ChonHeCoso();

                Console.Write($"\nNhap Vao so can doi {He1}: ");
                string inputValue = Console.ReadLine();

                long decimalValue = Convert.ToInt64(inputValue, He1);

                string outputValue = Convert.ToString(decimalValue, He2);
                Console.WriteLine($"Ket Qua: {outputValue.ToUpper()} (base {He2})");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: So nhap vao khong dung dinh dang duoc chon ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Da xaay ra loi : {ex.Message}");
            }
        }
    }

}
