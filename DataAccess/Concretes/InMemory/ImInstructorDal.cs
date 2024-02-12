using KodlamaIoModelleme.DataAccess.Abstracts;
using KodlamaIoModelleme.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.DataAccess.Concretes.InMemory;

public class ImInstructorDal:IInstructorDal

{
    List<Instructor> instructors = new List<Instructor>();

    public ImInstructorDal()
    {
        instructors.Add(new Instructor {InstructorId =1, FirstName="Engin", LastName="Demiroğ", ImageUrl= "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:30,height:30/https://www.filepicker.io/api/file/GsqiGFGCRmuBuel0qqF3" });

        instructors.Add(new Instructor { InstructorId = 2, FirstName = "Halit Enes", LastName = "Kalaycı", ImageUrl = "https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:30,height:30/https://cdn.filestackcontent.com/XwoZsQ1LTaOU9ke59grx" });
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public List<Instructor> GetInstructors()
    {
        return instructors;
    }
}
