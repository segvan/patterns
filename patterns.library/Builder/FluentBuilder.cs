using patterns.library.Models;

namespace patterns.library.Builder
{
    public class FluentBuilder
    {
        private HtmlElement root = new HtmlElement();

        public FluentBuilder(string rootName)
        {
            root.Name = rootName;
        }

        public FluentBuilder AddChildFluent(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.Elements.Add(e);
            return this;
        }

        public HtmlElement Build()
        {
            return root;
        }
    }
}