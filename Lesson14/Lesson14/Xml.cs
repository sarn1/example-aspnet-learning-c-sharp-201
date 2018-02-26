using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson14
{
    public class Xml : DynamicObject
    {
        private readonly XDocument _root;
        private XContainer _current;

        public Xml()
        {
            _root = new XDocument();
            _current = _root;
        }

        public override bool TryInvokeMember(InvokeMemberBinder binder, 
            object[] args, out object result)
        {
            CreateElement(binder.Name, args);
            result = null;
            return true;
        }

        public static Action<dynamic> Element(Action<dynamic> fn)
        {
            return fn;
        }

        private void CreateElement(string tagName, object[] args)
        {
            var element = new XElement(tagName);
            _current.Add(element);

            foreach (var arg in args)
            {
                var content = string.Empty;
                Action<dynamic> action = null;

                if (arg is string)
                {
                    content = (string) arg;
                } else if (arg is Action<dynamic>)
                {
                    action = (Action<dynamic>) arg;
                }

                if (!string.IsNullOrEmpty(content))
                {
                    element.Add(content);
                }

                if (action != null)
                {
                    _current = element;
                    action(this);
                    _current = element.Parent;
                }
            }
        }

        public override string ToString()
        {
            return _root.ToString();
        }
    }
}
