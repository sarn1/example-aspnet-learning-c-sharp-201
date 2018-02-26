using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14
{
    public class Simple : DynamicObject
    {
        private readonly Dictionary<string, object> _props = 
            new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, 
            object value)
        {
            var key = binder.Name;

            _props[key] = value;

            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder, 
            out object result)
        {
            return _props.TryGetValue(binder.Name, out result);
        }
    }
}
