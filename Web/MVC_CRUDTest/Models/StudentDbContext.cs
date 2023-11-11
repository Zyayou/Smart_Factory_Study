using Microsoft.EntityFrameworkCore;

namespace MVC_CRUDTest.Models
{
    public class StudentDbContext : DbContext
    {
        //생성자, DB 연결 초기화
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            
        }
        //DB연결작업 --> appsettings.json
        //테이블 만들기
        public DbSet<Student> Student { get; set; }
    }
    
}
