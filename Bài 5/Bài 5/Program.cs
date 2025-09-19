using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Thiết lập console để hiển thị tiếng Việt
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            var studentList = new StudentList("H:\\My Drive\\bcse\\S5\\LTNC\\source\\repos\\Bài 5\\Bài 5\\students.txt");
            studentList.ReadFile(); // Tải dữ liệu khi chương trình bắt đầu

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("\n--- CHƯƠNG TRÌNH QUẢN LÝ SINH VIÊN ---");
                Console.WriteLine("1. Hiển thị tất cả sinh viên");
                Console.WriteLine("2. Tìm kiếm sinh viên theo tên");
                Console.WriteLine("3. Sửa thông tin sinh viên");
                Console.WriteLine("4. Xóa sinh viên");
                Console.WriteLine("5. Thống kê khóa học");
                Console.WriteLine("6. Thoát");
                Console.Write("Vui lòng chọn chức năng: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        studentList.DisplayAllStudents();
                        break;
                    case "2":
                        SearchStudent(studentList);
                        break;
                    case "3":
                        SuaXoa(studentList, "update");
                        break;
                    case "4":
                        SuaXoa(studentList, "delete");
                        break;
                    case "5":
                        studentList.GenerateCourseReport();
                        break;
                    case "6":
                        loop = false;
                        Console.WriteLine("Kết thúc chương trình !");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
        }

        static void SearchStudent(StudentList studentList)
        {
            Console.Write("Nhập tên sinh viên cần tìm: ");
            string name = Console.ReadLine();
            var results = studentList.FindStudentsByName(name);

            if (results.Count > 0)
            {
                Console.WriteLine($"=> Tìm thấy {results.Count} kết quả cho '{name}':");
                foreach (var student in results)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine($"(!) Không tìm thấy sinh viên nào có tên '{name}'.");
            }
        }

        static void SuaXoa(StudentList studentList, string mode)
        {
            Console.Write($"Nhập tên sinh viên cần {mode}: ");
            string name = Console.ReadLine();
            var results = studentList.FindStudentsByName(name);

            if (results.Count == 0)
            {
                Console.WriteLine($"(!) Không tìm thấy sinh viên nào có tên '{name}'.");
                return;
            }

            Console.WriteLine($"=> Tìm thấy {results.Count} bản ghi. Vui lòng chọn bản ghi để {mode}:");
            for (int i = 0; i < results.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {results[i]}");
            }
            Console.Write("Chọn (nhập số thứ tự): ");

            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= results.Count)
            {
                var studentToActOn = results[index - 1];
                if (mode == "update")
                {
                    studentList.UpdateStudent(studentToActOn);
                }
                else if (mode == "delete")
                {
                    if (studentList.DeleteStudent(studentToActOn))
                    {
                        Console.WriteLine("Xóa thành công!");
                    }
                }
            }
            else
            {
                Console.WriteLine("(!) Lựa chọn không hợp lệ.");
            }
        }
    }
}