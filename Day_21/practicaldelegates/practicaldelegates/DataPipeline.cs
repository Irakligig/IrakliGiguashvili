using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaldelegates
{
    internal class DataPipeline<T>
    {
        List<Func<T,bool>> filtering = new List<Func<T,bool>>();
        List<Func<T, object>> transformation = new List<Func<T, object>>();

        public void AddFilter(Func<T , bool> filter)
        {
            filtering.Add(filter);
        }

        public void AddTransofrm<Tout>(Func<T , Tout> transform)
        {
            transformation.Add(item => transform(item));
        }
        public IEnumerable<Tout> Process<Tout>(IEnumerable<T> input)
        {
            var filtered = input.Where(item => filtering.All(filter => filter(item)));

            var transformed = filtered.Select(item => transformation.Aggregate(item, (current, transform) => (T)transform(current)));

            return transformation.Cast<Tout>();
        }
    }
}
