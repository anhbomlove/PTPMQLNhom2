using MvcMovie.Models;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class StudentController : Controller
    {
        // Action để hiển thị form và dữ liệu từ ViewBag
        public IActionResult Index()
        {
            ViewBag.InfoMessage = "Nhập điểm các thành phần A, B, C để tính điểm tổng kết:";
            return View();
        }

        // Action để nhận thông tin từ form và tính toán điểm tổng kết
        [HttpPost]
        public IActionResult Index(Student st)
        {
            // Tính toán điểm tổng kết
            double finalScore = st.CalculateFinalScore();
            // Gửi kết quả đến View
            ViewBag.InfoMessage = $"Điểm tổng kết của {st.FullName} là: {finalScore:F2}";
            return View(st);
        }
    }
}