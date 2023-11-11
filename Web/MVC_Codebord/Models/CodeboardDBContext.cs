using Microsoft.EntityFrameworkCore;

namespace MVC_Codebord.Models
{
	public class CodeboardDBContext : DbContext
	{
		//생성자, DB 연결 초기화
		public CodeboardDBContext(DbContextOptions options) : base(options)
		{

		}
		//DB연결작업 --> appsettings.json
		//테이블 만들기
		public DbSet<Codeboard> Codeboard { get; set; }
	}
}
