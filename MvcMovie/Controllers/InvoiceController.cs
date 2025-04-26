using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        public IActionResult Index()
        {
            // Khởi tạo đối tượng Invoice với giá trị mặc định khi view được tải lần đầu
            return View(new Invoice());  // Trả về Model rỗng hoặc với giá trị mặc định
        }

        // POST: Invoice
        [HttpPost]
        public IActionResult Index(Invoice invoice)
        {
            // Kiểm tra nếu model hợp lệ
            if (ModelState.IsValid)
            {
                // Tính toán tổng tiền hóa đơn
                invoice.CalculateTotalAmount();
                // Cập nhật thông báo sau khi tính toán xong
                ViewBag.InfoMessage = $"Tổng tiền hóa đơn của bạn là: {invoice.TotalAmount:F2} VNĐ";
                // Trả về lại Model để hiển thị kết quả
                return View(invoice);
            }
            // Nếu dữ liệu không hợp lệ, vẫn trả lại view để người dùng chỉnh sửa
            ViewBag.InfoMessage = "Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.";
            return View(invoice);
        }
    }
}
