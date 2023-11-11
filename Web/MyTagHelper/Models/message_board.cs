namespace MyTagHelper.Models
{
    public class message_board
    {
        public string Title { get; set; }
        public string Writer { get; set; }
        public DateTime WriteDate { get; set; }
        public Categories Categories { get; set; }
        public string Description { get; set; }
        public string IsPublic { get; set; }
    }
    public enum Categories
    {
        자유,
        유머,
        노래,
        그림,
        코드,
        게임
    }
}
