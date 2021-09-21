using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Single_Feedback<T> : Feedback
    {
        public T Item { get; set; }
    }
}
