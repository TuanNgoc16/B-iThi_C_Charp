namespace baithi
{
    class Program
    {
        string name;
        int weight;

        public void setme(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public void show()   
        {
            Console.WriteLine("Name: " + name + ",Weight: " + weight);
        }
    }

}

