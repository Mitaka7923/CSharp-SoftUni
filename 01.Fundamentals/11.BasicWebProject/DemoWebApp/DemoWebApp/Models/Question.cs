using System.ComponentModel.DataAnnotations;

namespace DemoWebApp.Models
{
    public class Question
    {
        private static int nextId = 1;

        [Required]
        public string Text { get; set; }
        
        [Required]
        public string Author { get; set; }
        public int ID { get; set; }

        public Question(string text, string author)
        {
            this.Text = text;
            this.Author = author;
            this.ID = nextId++;
        }
    }
}
