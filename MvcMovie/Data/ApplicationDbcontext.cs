using Microsoft.EntityFrameworkCore;
using VicemMVCIdentity.Models.Entities; // Thêm dòng này
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MvcMovie.Models; // Add this line if ApplicationUser is in MvcMovie.Models namespaceusing Microsoft.EntityFrameworkCore;

namespace MvcMovie.Data
{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //Ánh xạ class Student vào trong csdl => tạo ra bảng Students

        public DbSet<Person> Person { get; set; } = default!;

        public DbSet<VicemMVCIdentity.Models.Entities.Employee> Employees { get; set; } = default!;
    }

}