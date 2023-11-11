using MVC_Model2.Models;

namespace MVC_Model2.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }
        public StudentModel getStudentById(int id)
        {
            return DataSource().Where(x => x.ID == id).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            var students = new List<StudentModel> {

                new StudentModel {ID = 1, Name = "홍길동", HP = "010-1111-1111", Majer = "컴퓨터공학과"},
                new StudentModel {ID = 2, Name = "이순신", HP = "010-2222-2222", Majer = "정보통신공학과"},
                new StudentModel {ID = 3, Name = "강감찬", HP = "010-3333-3333", Majer = "기계설계공학과"}
            };

            return students;
        }
        
    }
}
