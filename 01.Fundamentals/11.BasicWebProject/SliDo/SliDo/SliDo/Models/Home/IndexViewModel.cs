namespace SliDo.Models.Home
{
    public class IndexViewModel
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public IndexViewModel() { }
        public IndexViewModel(int id, string author, string text) 
        {
            this.Id = id;
            this.Author = author;
            this.Text = text;
        }
    }
}
