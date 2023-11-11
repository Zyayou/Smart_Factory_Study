namespace MVC_ScoreQuiz.Models
{
    public class Subject
    {
        public int kor { get; set; }
        public int eng { get; set; }
        public int math { get; set; }
        public int soc { get; set; }
        public int sci { get; set; }
    }
    public enum Score
    {
        Ap = 100,
        A = 95,
        Bp = 90,
        B = 80,
        Cp = 75,
        C = 70,
        Dp = 65,
        D = 60
    }

}
