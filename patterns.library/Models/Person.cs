namespace patterns.library.Models
{
    public class Person
    {
        public string Name, Position;
        
        public override string ToString()
        {
            return $@"Person name: {Name}, position: {Position}";
        }
    }
}