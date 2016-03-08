namespace LearnCSharp
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        private static int InstaceCount { get; set; }

        private static readonly object counterLock = new object();

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

            lock (counterLock)
            {
                InstaceCount++;
            }
        }
    }
}