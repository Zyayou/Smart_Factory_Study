using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Security;
using System.Xml.Linq;

namespace MyProject_RentalShop_Console
{
	public class CD
	{
		[Key]
		public int CDID { get; set; }  //ID
		public string Title { get; set; } //제목
		public string CompatibleEquipment { get; set; } //호환장비
		public string Genre { get; set; } //장르
		public string Rating { get; set; } //연령 등급
		public string Distributor { get; set; } //배급사
		public string ReleaseDate { get; set; } //출시일
		public bool onLoan { get; set; } //대여 여부

		//public string Loanee { get; set; } //대여인
	}
	/*
	//회원들
	public class Customer
	{
		[Key]
		public int CusID { get; set; } //id
		public string Name { get; set; } //이름
		public int Age { get; set; } //나이
		public string Address { get; set; } //주소

	}
	
	public class RentalList
	{
		[Key]
		public int RentalID { get; set; } //대여 id
		public int CusID { get; set; } //대여인 id
		public string Title { get; set; } //제목
		public string RentalDate { get; set; } //대여날짜
		public string ReturnDate { get; set; } //반납날짜

	}
	*/
	public class CDContext : DbContext
	{
		public DbSet<CD> CDs { get; set; }

		//접속문자열
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseOracle("User Id=c##scott;Password=c##tiger;Data Source=127.0.0.1/XE;");
		}

		//테이블 생성 및 제약
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<CD>()   //Primary key 지정
			.HasKey(p => p.CDID);

			modelBuilder.Entity<CD>()   //Varchar2(30) 30크기를 정할 때
				.Property(p => p.Title)
				.HasMaxLength(30);

			modelBuilder.Entity<CD>()
				.Property(p => p.CompatibleEquipment)
				.HasMaxLength(30);

			modelBuilder.Entity<CD>()
				.Property(p => p.Genre)
				.HasMaxLength(30);

			modelBuilder.Entity<CD>()
				.Property(p => p.Rating)
				.HasMaxLength(30);

			modelBuilder.Entity<CD>()
				.Property(p => p.Distributor)
				.HasMaxLength(30);

			modelBuilder.Entity<CD>()
				.Property(p => p.ReleaseDate)
				.HasMaxLength(30);

		}
	}
	/*
	public class CustomerContext : DbContext
	{
		public DbSet<Customer> Customers { get; set; }

		//접속문자열
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseOracle("User Id=c##scott;Password=c##tiger;Data Source=127.0.0.1/XE;");
		}

		//테이블 생성 및 제약
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Customer>()   //Primary key 지정
			.HasKey(p => p.CusID);

			modelBuilder.Entity<Customer>()   //Varchar2(30) 30크기를 정할 때
				.Property(p => p.Name)
				.HasMaxLength(30);

			modelBuilder.Entity<Customer>()
				.Property(p => p.Address)
				.HasMaxLength(30);
		}
	}
	public class RentalListContext : DbContext
	{
		public DbSet<RentalList> RentalLists { get; set; }

		//접속문자열
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseOracle("User Id=c##scott;Password=c##tiger;Data Source=127.0.0.1/XE;");
		}

		//테이블 생성 및 제약
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<RentalList>()   //Primary key 지정
			.HasKey(p => p.RentalID);

			modelBuilder.Entity<RentalList>()   //Varchar2(30) 30크기를 정할 때
				.Property(p => p.Title)
				.HasMaxLength(30);

			modelBuilder.Entity<RentalList>()
				.Property(p => p.RentalDate)
				.HasMaxLength(30);

			modelBuilder.Entity<RentalList>()
				.Property(p => p.ReturnDate)
				.HasMaxLength(30);

		}
	}
	*/
	
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			using (var context = new CDContext())
			{
				// 데이터베이스와 테이블 생성 (필요한 경우)
				//context.Database.EnsureDeleted();
				context.Database.EnsureCreated();

				// 데이터 삽입
				var CDs = new List<CD>
				{
					new CD { CDID = 100, Title = "디아블로4", CompatibleEquipment = "PS5", Genre = "유니크",
							Rating = "18세 이상",  Distributor = "블리자드 엔터테인먼트", ReleaseDate="2023.06.06", onLoan=false},
					new CD { CDID = 200, Title = "호그와트 레거시", CompatibleEquipment = "PS5", Genre = "액션RPG",
							Rating = "12세 이용가",  Distributor = "워너 브라더스 인터렉티브 엔터테인먼트", ReleaseDate="2023.02.10", onLoan=false},
					new CD { CDID = 300, Title = "롤러코스터 타이쿤3", CompatibleEquipment = "PC", Genre = "시뮬레이션",
							Rating = "전체이용가",  Distributor = "아타리", ReleaseDate="2004.11.09", onLoan=false},
					new CD { CDID = 400, Title = "바이오하자드 RE 4", CompatibleEquipment = "PS5", Genre = "서바이벌 호러",
							Rating = "18세 이상",  Distributor = "CAPCOM", ReleaseDate="2023.03.24", onLoan=false},
					new CD { CDID = 500, Title = "시드 마이어의 문명 6", CompatibleEquipment = "PC", Genre = "전략 시뮬레이션",
							Rating = "12세 이용가",  Distributor = "Firaxis Games", ReleaseDate="2016.10.21", onLoan=false}
				};

				context.CDs.AddRange(CDs);
				context.SaveChanges();
				Console.WriteLine("CD 데이터 삽입 완료");

			}
			*/

			/*
			using (var context = new CustomerContext())
			{
				// 데이터베이스와 테이블 생성 (필요한 경우)
				//context.Database.EnsureDeleted();
				context.Database.EnsureCreated();

				// 데이터 삽입
				var Customers = new List<Customer>
				{
					new Customer { CusID = 1, Name = "홍길동", Age = 22, Address = "서울" },
					new Customer { CusID = 2, Name = "정동원", Age = 15, Address = "대전" },
					new Customer { CusID = 3, Name = "이철수", Age = 18, Address = "부산" }
				};

				context.Customers.AddRange(Customers);
				context.SaveChanges();
				Console.WriteLine("고객 데이터 삽입 완료");

			}
			using (var context = new RentalListContext())
			{
				// 데이터베이스와 테이블 생성 (필요한 경우)
				//context.Database.EnsureDeleted();
				context.Database.EnsureCreated();

				// 데이터 삽입
				var RentalLists = new List<RentalList>
				{
					new RentalList { RentalID = 1, CusID = 1, Title = "디아블로4", RentalDate = "2023.05.08", ReturnDate = "2023.05.20" },
					new RentalList { RentalID = 2, CusID = 2, Title = "롤러코스터 타이쿤3", RentalDate = "2023.05.15", ReturnDate = "2023.05.18" },
					new RentalList { RentalID = 3, CusID = 2, Title = "호그와트 레거시", RentalDate = "2023.05.18", ReturnDate = "2023.06.18" },
					new RentalList { RentalID = 5, CusID = 1, Title = "바이오하자드 RE 4", RentalDate = "2023.05.20", ReturnDate = "2023.05.29" },
					new RentalList { RentalID = 4, CusID = 3, Title = "디아블로4", RentalDate = "2023.05.21", ReturnDate = "2023.06.19" },
					new RentalList { RentalID = 6, CusID = 1, Title = "롤러코스터 타이쿤3", RentalDate = "2023.05.29", ReturnDate = "2023.06.01" },
					new RentalList { RentalID = 7, CusID = 3, Title = "디아블로4", RentalDate = "2023.05.08", ReturnDate = "2023.05.20" },
					new RentalList { RentalID = 8, CusID = 1, Title = "시드 마이어의 문명 6", RentalDate = "2023.06.01", ReturnDate = "2023.06.03" },
					new RentalList { RentalID = 9, CusID = 2, Title = "시드 마이어의 문명 6", RentalDate = "2023.06.18", ReturnDate = "2023.06.30" }
				};

				context.RentalLists.AddRange(RentalLists);
				context.SaveChanges();
				Console.WriteLine("기록 데이터 삽입 완료");

			}
			*/

			while(true)
			{
				Console.Write("1. 전체 목록보기(+대여)\r\n" +
					"2. 내가 대여중인 목록보기(+반납)\r\n" +
					"3. CD추가\r\n" +
					"4. CD삭제\r\n" +
					"5. 나의 대여 기록 보기(추후 생성)\r\n "); //왜 DB 두세개는 안되는 걸까 어헝헝
				Console.Write("원하시는 동작의 번호를 입력하세요 : ");
				int input = int.Parse(Console.ReadLine());
				if (input == 0)
				{
					break;
				}
				else if (input == 1)
				{
					using (var context = new CDContext())
					{
						var CDs = context.CDs.ToList();


						foreach (var item in CDs)
						{
							Console.Write($"{item.CDID} | {item.Title} | {item.CompatibleEquipment} | {item.Genre}" +
								$" | {item.Rating} | {item.Distributor} | {item.ReleaseDate} | ");
							if (item.onLoan == true)
							{
								Console.WriteLine("대여중");
							}
							else
							{
								Console.WriteLine("대여가능");
							}
						}
					}

					Console.Write("\r\n1. 대여하기\r\n" +
					"그외. 이전 메뉴로 나가기\r\n");
					Console.Write("원하시는 동작의 번호를 입력하세요 : ");
					int input1 = int.Parse(Console.ReadLine());
					if (input1 == 1)
					{
						Console.Write("대여하실 CD의 번호를 입력하세요 : ");
						int input1_1 = int.Parse(Console.ReadLine());
						using (var context = new CDContext())
						{
							var update = context.CDs.FirstOrDefault(p => p.CDID == input1_1);
							if (update != null)
							{
								if (update.onLoan == true)
								{
									Console.WriteLine("이미 대여중인 CD입니다.");
								}
								else
								{
									update.onLoan = true;

									context.SaveChanges();
									Console.WriteLine("대여하였습니다.");
								}
							}
							else
							{
								Console.WriteLine("없는 번호 입니다.");
							}
						}
					}
				}
				else if (input == 2)
				{
					using (var context = new CDContext())
					{
						var CDs = context.CDs.ToList();
						foreach (var item in CDs)
						{
							if (item.onLoan == true)
							{
								Console.WriteLine($"{item.CDID} | {item.Title} | {item.CompatibleEquipment} | {item.Genre}" +
								$" | {item.Rating} | {item.Distributor} | {item.ReleaseDate} ");
							}
						}
					}
					Console.WriteLine();
					Console.Write("\r\n1. 반납하기\r\n" +
						"그외. 이전 메뉴로 나가기\r\n");
					Console.Write("원하시는 동작의 번호를 입력하세요 : ");
					int input2 = int.Parse(Console.ReadLine());
					if (input2 == 1)
					{
						Console.Write("반납하실 CD의 번호를 입력하세요 : ");
						int input2_1 = int.Parse(Console.ReadLine());
						using (var context = new CDContext())
						{
							var update = context.CDs.FirstOrDefault(p => p.CDID == input2_1);
							if (update != null)
							{
								if (update.onLoan == false)
								{
									Console.WriteLine("없는 번호 입니다");
								}
								else
								{
									update.onLoan = false;

									context.SaveChanges();
									Console.WriteLine("반납하였습니다.");
								}
							}
							else
							{
								Console.WriteLine("없는 번호 입니다.");
							}
						}
					}
					Console.WriteLine();
				}
				else if (input == 3)
				{
					
					using (var context = new CDContext())
					{
						var CDs = context.CDs.ToList();
						Console.Write("CDID : ");
						int input_ID = int.Parse(Console.ReadLine());
						Console.Write("타이틀 : ");
						string input_Title = Console.ReadLine();
						Console.Write("호환 기기 : ");
						string input_CompatibleEquipment = Console.ReadLine();
						Console.Write("장르 : ");
						string input_Genre = Console.ReadLine();
						Console.Write("연령제한 : ");
						string input_Rating = Console.ReadLine();
						Console.Write("배급사 : ");
						string input_Distributor = Console.ReadLine();
						Console.Write("출시일 : ");
						string input_ReleaseDate = Console.ReadLine();

						var CD = new List<CD>
						{
							new CD {
							CDID = input_ID,
							Title = input_Title,
							CompatibleEquipment = input_CompatibleEquipment,
							Genre = input_Genre,
							Rating = input_Rating,
							Distributor = input_Distributor,
							ReleaseDate = input_ReleaseDate,
							onLoan = false
							}
						};
						context.CDs.AddRange(CD);
						context.SaveChanges();
						Console.WriteLine("등록 완료");
					}
				}
				else if (input == 4)
				{

					Console.Write("삭제할 CD의 ID를 입력해주세요 : ");
					int input_del = int.Parse(Console.ReadLine());
					using (var context = new CDContext())
					{
						var delete = context.CDs.FirstOrDefault(p => p.CDID == input_del);
						if (delete != null)
						{
							context.CDs.Remove(delete);

							context.SaveChanges();
							Console.WriteLine("삭제 완료");
						}
					}
				}
				else
				{
					Console.WriteLine("종료를 원하시면 '0'을 입력해 주세요");
				}
				Console.WriteLine();
			}
		}
	}
}