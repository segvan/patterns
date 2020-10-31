using patterns.library.Models;

namespace patterns.library.Builder
{
    public class Builder
    {
        private HtmlElement root = new HtmlElement();

        public Builder(string rootName)
        {
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
        }

        public HtmlElement Build()
        {
            return root;
        }
    }
}