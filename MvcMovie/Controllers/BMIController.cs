using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI
        public IActionResult Index()
        {
            // Khởi tạo model BMIModel và trả về view
            return View(new BMIModel());
        }

        // POST: BMI
        [HttpPost]
        public IActionResult Index(BMIModel bmiModel)
        {
            // Kiểm tra nếu model hợp lệ
            if (ModelState.IsValid)
            {
                // Nếu hợp lệ, bạn có thể tính toán BMI và trả về kết quả
                ViewBag.InfoMessage = $"Chỉ số BMI của bạn là: {bmiModel.BMI:F2}, Kết quả: {bmiModel.Result}";
                return View(bmiModel);  // Trả lại Model để hiển thị kết quả
            }

            // Nếu model không hợp lệ, hiển thị thông báo lỗi
            ViewBag.InfoMessage = "Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.";
            return View(bmiModel);  // Trả lại Model để người dùng sửa lỗi
        }
    }
}
