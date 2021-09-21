using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metadata.Interfaces
{
    public interface ITeacher
    {
        Feedback Insert(Teacher t);
        Feedback Update(Teacher s);
        Feedback Turn_Desactivated(int id);
        Feedback Turn_Activated(int id);
    }
}
