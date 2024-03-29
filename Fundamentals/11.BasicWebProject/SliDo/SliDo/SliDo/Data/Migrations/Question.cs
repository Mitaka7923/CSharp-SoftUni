namespace SliDo.Data.Migrations
{
    public class Question
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public bool IsAnswered { get; set; }

        public Question() { }
        public Question(string? author, string text) 
        {
            this.Created = DateTime.UtcNow;
            this.Author = author is null ? "Anonymous" : author;
            this.Text = text;
        }
    }
}
