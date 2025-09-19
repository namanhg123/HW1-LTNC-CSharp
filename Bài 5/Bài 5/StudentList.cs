using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentApp;
using System.IO;

namespace StudentApp
{
    public class StudentList
    {
        private List<Student> _students;
        private readonly string _filePath;

        public StudentList(string filePath)
        {
            _students = new List<Student>();
            _filePath = filePath;
        }

        // 1. Đọc danh sách sinh viên từ tệp
        public void ReadFile()
        {
            if (!File.Exists(_filePath))
            {
                Console.WriteLine("Tệp dữ liệu không tồn tại.");
                return;
            }

            var lines = File.ReadAllLines(_filePath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var parts = line.Split(',');

                if (parts.Length == 3)
                {
                    string name = parts[0].Trim();
                    if (int.TryParse(parts[1].Trim(), out int semester) &&
                        TryParseCourse(parts[2].Trim(), out Course course))
                    {
                        _students.Add(new Student(name, semester, course));
                    }
                }
            }
            Console.WriteLine($"Tải thành công {_students.Count} bản ghi sinh viên.");
        }

        // Hàm hỗ trợ chuyển đổi chuỗi thành enum Course
        private bool TryParseCourse(string courseStr, out Course course)
        {
            switch (courseStr.ToLower())
            {
                case "java":
                    course = Course.Java;
                    return true;
                case "python":
                    course = Course.Python;
                    return true;
                case "csharp":
                    course = Course.CSharp;
                    return true;
                case "javascript":
                    course = Course.JavaScript;
                    return true;
                default:
                    course = default;
                    return false;
            }
        }

        // 2. Tìm kiếm sinh viên theo tên (có thể trả về nhiều kết quả)
        public List<Student> FindStudentsByName(string name)
        {
            return _students.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // 3a. Xóa một sinh viên
        public bool DeleteStudent(Student student)
        {
            return _students.Remove(student);
        }

        // 3b. Sửa thông tin sinh viên (được truyền vào đối tượng student cần sửa)
        public void UpdateStudent(Student student)
        {
            Console.Write($"Nhập học kỳ mới (hiện tại: {student.Semester}): ");
            if (int.TryParse(Console.ReadLine(), out int newSemester))
            {
                student.Semester = newSemester;
            }

            Console.Write($"Nhập khóa học mới (hiện tại: {student.CourseName}) [Java, Python, CSharp, JavaScript]: ");
            if (TryParseCourse(Console.ReadLine(), out Course newCourse))
            {
                student.CourseName = newCourse;
            }
            Console.WriteLine("Cập nhật thành công!");
        }

        // 4. Thống kê số lần đăng ký khóa học của mỗi sinh viên
        public void GenerateCourseReport()
        {
            Console.WriteLine("\n--- Thống kê số lần đăng ký khóa học ---");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"| {"Student Name",-15} | {"Course",-10} | {"Total",-5} |");
            Console.WriteLine("-------------------------------------------");

            var report = _students.GroupBy(s => s.Name).Select( gr => new
                {
                    StudentName = gr.Key,
                    CourseExample = gr.First().CourseName, // Lấy một khóa học làm ví dụ
                    TotalCourses = gr.Count() // Đếm số bản ghi trong nhóm
                })
                .OrderBy(r => r.StudentName);

            foreach (var item in report)
            {
                Console.WriteLine($"| {item.StudentName,-15} | {item.CourseExample,-10} | {item.TotalCourses,-5} |");
            }
            Console.WriteLine("-------------------------------------------");
        }

        // Hàm tiện ích để hiển thị tất cả sinh viên
        public void DisplayAllStudents()
        {
            Console.WriteLine("\n--- Danh sách tất cả sinh viên ---");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"| {"Họ và Tên",-25} | {"Học kỳ",-10} | {"Khóa học",-15} |");
            Console.WriteLine("-----------------------------------------------------------------");
            if (_students.Count == 0)
            {
                Console.WriteLine("| Không có sinh viên nào trong danh sách.                       |");
            }
            else
            {
                foreach (var student in _students)
                {
                    Console.WriteLine(student);
                }
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
    }
}
