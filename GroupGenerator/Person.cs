namespace GroupGenerator
{
    public class Person
    {
        public virtual string Name { get; set; }

        public Person(string name = "")
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

}