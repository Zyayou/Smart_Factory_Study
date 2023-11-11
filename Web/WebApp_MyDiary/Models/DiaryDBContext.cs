using Microsoft.EntityFrameworkCore;

namespace WebApp_MyDiary.Models
{
    public class DiaryDBContext : DbContext
    {
        //생성자, DB 연결 초기화
        public DiaryDBContext(DbContextOptions options) : base(options)
        {

        }
        //DB연결작업 --> appsettings.json
        //테이블 만들기
        public DbSet<Diary> Diary { get; set; }
    }
}
