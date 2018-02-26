using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    public class PersonCollection : IEnumerable<Person>
    {
        private readonly List<Person> _people;

        public PersonCollection()
        {
            _people = new List<Person>();
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }

        public Person this[int index]
        {
            get
            {
                if (index > -1 && index < _people.Count)
                {
                    return _people[index];
                }

                throw new IndexOutOfRangeException();
            }
            set { _people[index] = value; }
        }

        public IEnumerable<Person> this[string firstName, string lastName]
        {
            get { return _people.Where(p => p.FirstName == firstName && p.LastName == lastName); }
        } 

        public IEnumerator<Person> GetEnumerator()
        {
            return _people.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _people.GetEnumerator();
        }
    }
}
