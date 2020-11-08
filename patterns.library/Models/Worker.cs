namespace patterns.library.Models
{
    public class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public Office Office { get; set; }

        // Need parameterless constructor for deserialization
        public Worker()
        {
        }
        
        public Worker(string name, string position, Office office)
        {
            Name = name;
            Position = position;
            Office = office;
        }

        public override string ToString()
        {
            return $@"Person name: {Name}, position: {Position}, office: {Office}";
        }
    }

    public class Office
    {
        public string Street { get; set; }
        public int Number { get; set; }

        // Need parameterless constructor for deserialization
        public Office()
        {
        }
        
        public Office(string street, int number)
        {
            Street = street;
            Number = number;
        }

        public override string ToString()
        {
            return $@"street: {Street}, number: {Number}";
        }
    }
}