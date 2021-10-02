using Builders.Models;

namespace Builders
{
    class HtmlBuilder
    {        
        protected readonly HtmlElement _root;

        public HtmlBuilder(HtmlElement root)
        {
            _root = root;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            _root.AddChild(childName, childText);
            return this;
        }

        public override string ToString() => _root.ToString();

        public static implicit operator string(HtmlBuilder builder)
        {
            return builder.ToString();
        }        
    }
}