namespace _02.Articles
{
    internal class Article
    {
        internal string Title { get; set; }
        internal string Content { get; set; }
        internal string Author { get; set; }

        internal Article(string[]? content)
        {
            this.Title = content[0];
            this.Content = content[1];
            this.Author = content[2];
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
            var articleCount = int.Parse(Console.ReadLine());
            var articles = new List<Article>();

            for (int i = 0; i < articleCount; i++)
            {
                var articleContents = Console.ReadLine().Split(", ");
                articles.Add(new Article(articleContents));
            }

            articles.ForEach((x) => Console.WriteLine(x.ToString()));
        }
    }
}
