namespace _01.UniqueUsernames
{
    internal class SoftUniHashSet
    {
        private List<string>[] internalArray;
        private double elementsCount = 0;
        private int maxCapacity = 60;

        public SoftUniHashSet()
        {
            this.internalArray = new List<string>[8];
        }

        public SoftUniHashSet(int capacity)
        {
            this.internalArray = new List<string>[capacity];
        }

        internal void Add(string el)
        {
            var index = HashFunction(el);
            var existing = false;

            if (this.internalArray[index] == null)
            {
                this.internalArray[index] = new List<string>();
            }

            foreach (var item in this.internalArray[index])
            {
                if (item == el)
                {
                    existing = true;
                }
            }

            if (!existing)
            {
                this.internalArray[index].Add(el);
                elementsCount++;
                if (elementsCount / this.internalArray.Length * 100 > maxCapacity)
                {
                    Resize();
                }
            }
        }

        private void Resize()
        {
            this.elementsCount = 0;
            var oldInternalArray = this.internalArray;
            this.internalArray = new List<string>[oldInternalArray.Length * 2];

            foreach (var item in oldInternalArray)
            {
                if (item != null)
                {
                    foreach (var i in item)
                    {
                        Add(i);
                    }
                }
            }
        }

        internal bool Contains(string el) 
        {
            var index = HashFunction(el);

            if (this.internalArray[index] != null)
            {
                for (int i = 0; i < this.internalArray[index].Count; i++)
                {
                    if (this.internalArray[index][i] == el)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        internal int HashFunction(string el)
        {
            return Math.Abs(el.GetHashCode() % this.internalArray.Length);
        }
    }
}
