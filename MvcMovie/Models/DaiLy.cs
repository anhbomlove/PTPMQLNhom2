using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace MvcMovie.Models;

public class DaiLy : HeThongPhanPhoi
{
    public string? MaDaiLy  {get; set; }
    public string? TenDaiLy   {get; set; }
    public string? DiaChi   {get; set; }
    public string? NguoiDaiDien  {get; set; }
    public string? DienThoai  {get; set; }
    public string? MaHTPP  {get; set; }
}