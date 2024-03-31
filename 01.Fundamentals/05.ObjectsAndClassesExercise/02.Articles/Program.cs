namespace _02.Articles
{
    internal class Article
    {
        internal string Title { get; set; }
        internal string Content { get; set; }
        internal string Author { get; set; }

        internal Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        internal void Edit(string content)
        {
            this.Content = content;
        }

        internal void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        internal void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var commandCount = int.Parse(Console.ReadLine());

            var contents = input.Split(", ");
            var article = new Article(contents[0], contents[1], contents[2]);

            for (int i = 0; i < commandCount; i++)
            {
                var command = Console.ReadLine().Split(": ");

                switch (command[0].ToLower())
                {
                    case "edit": article.Edit(command[1]); break;
                    case "changeauthor": article.ChangeAuthor(command[1]); break;
                    case "rename": article.Rename(command[1]); break;
                    default: break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}
