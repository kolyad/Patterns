using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builders.Models
{
    class HtmlElement
    {
        private readonly string _name;
        private readonly string _text;

        protected readonly List<HtmlElement> Elements = new List<HtmlElement>();

        protected HtmlElement()
        {

        }

        protected HtmlElement(string name, string text = null)
        {
            _name = name;
            _text = text;
        }

        public void AddChild(string childName, string childText)
        {
            Elements.Add(new HtmlElement(childName, childText));
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            
            sb.Append($"<{_name}>");
            
            if (Elements.Any())
            {
                foreach (var item in Elements)
                {
                    sb.AppendFormat(item.ToString());
                }
            }
            else if (!string.IsNullOrEmpty(_text))
            {
                sb.AppendFormat(_text);
            }
            
            sb.Append($"</{_name}>");

            return sb.ToString();
        }

        // Factory method
        public static HtmlBuilder Create(string rootName) => new HtmlBuilder(new HtmlElement(rootName));
    }
}
