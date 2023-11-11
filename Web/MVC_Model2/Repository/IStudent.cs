using MVC_Model2.Models;

namespace MVC_Model2.Repository
{
    public interface IStudent
    {
        //만들고자 하는 기능
        //1.전체검색
        List<StudentModel> getAllStudents();
        //2.특정 ID만 검색
        StudentModel getStudentById(int id);
    }
}
