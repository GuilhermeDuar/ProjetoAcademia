using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Data_Feedback<T> : Feedback
    {
        public List<T> Data { get; set; }

    }
}
