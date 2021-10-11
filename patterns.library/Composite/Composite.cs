using System.Collections.Generic;
using System.Text;

namespace patterns.library.Composite
{
    public class GraphicObject
    {
        public virtual string Name { get; set; } = "Group";

        public List<GraphicObject> Children { get; } = new List<GraphicObject>();

        public void AddChild(GraphicObject graphicObject)
        {
            Children.Add(graphicObject);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Print(0, sb);
            return sb.ToString();
        }

        private void Print(int depth, StringBuilder sb)
        {
            sb.Append(new string('-', depth)).Append(Name).AppendLine();
            foreach (var child in Children)
            {
                child.Print(depth + 1, sb);
            }
        }
    }

    public class Circle : GraphicObject
    {
        public override string Name => "Circle";
    }

    public class Square : GraphicObject
    {
        public override string Name => "Square";
    }
}