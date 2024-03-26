namespace _08.BeerKegs
{
    internal class Keg
    {
        public string Model { get; set; }
        public float Radius { get; set; }
        public int Height { get; set; }

        public double volume = 0;

        public Keg(string model, float radius, int height)
        {
            this.Model = model;
            this.Radius = radius;
            this.Height = height;
            this.volume = Math.PI * Math.Pow(this.Radius, 2) * this.Height;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var kegs = new List<Keg>();

            for (int i = 1; i <= n; i++)
            {
                var kegModel = Console.ReadLine();
                var kegRadius = float.Parse(Console.ReadLine());
                var kegHeight = int.Parse(Console.ReadLine());

                kegs.Add(new Keg(kegModel, kegRadius, kegHeight));
            }

            var biggerKeg = kegs[0];
            kegs.ForEach((keg) =>
            {
                if (keg.volume > biggerKeg.volume)
                {
                    biggerKeg = keg;
                }
            });

            Console.WriteLine(biggerKeg.Model);
        }
    }
}
