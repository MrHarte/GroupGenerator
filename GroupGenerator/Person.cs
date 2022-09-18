namespace GroupGenerator
{
    /// <summary>
    /// Represents one person saving their name
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Name of the person
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// Constructor for a person optionally adding their name
        /// </summary>
        /// <param name="name">Person's name, empty by default</param>
        public Person(string name = "")
        {
            Name = name.Trim();
        }

        /// <summary>
        /// Returns a string that represents the person
        /// </summary>
        /// <returns>String that represents the person</returns>
        public override string ToString()
        {
            return Name;
        }
    }

}