using KodlamaIoModelleme.DataAccess.Concretes.InMemory;
using KodlamaIoModelleme.Entities;

ImInstructorDal imInstructorDal = new ImInstructorDal();

foreach (var instructor in imInstructorDal.GetInstructors())
{
    Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}
