using KodlamaIoModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.DataAccess.Abstracts;

public interface IInstructorDal
{
    void Add(Instructor instructor);
    List<Instructor> GetInstructors();
}
