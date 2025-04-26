namespace MvcMovie.Models
{
    public class Student
    {
        // Thuộc tính của sinh viên
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public double PointA { get; set; }  // Điểm thành phần A
        public double PointB { get; set; }  // Điểm thành phần B
        public double PointC { get; set; }  // Điểm thành phần C

        // Phương thức tính điểm tổng kết
        public double CalculateFinalScore()
        {
            // Giả sử điểm tổng kết được tính theo công thức A*0.6 + B*0.3 + C*0.1
            return PointA * 0.6 + PointB * 0.3 + PointC * 0.1;
        }
    }
}