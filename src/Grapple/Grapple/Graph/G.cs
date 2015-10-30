using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grapple.Graph
{
    public class G<T> : IEnumerable<G<T>>
    {
        public T Value { get; set; }

        List<G<T>> Children { get; set; }

        public G<T> this[int index]
        {
            get
            {
                return Children[index];
            }
        }

        public int Count
        {
            get
            {
                return Children.Count;
            }
        }

        IEnumerator<G<T>> IEnumerable<G<T>>.GetEnumerator()
        {
            foreach(var i in Children)
            {
                yield return i;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var i in Children)
            {
                yield return i;
            }
        }
    }
}
