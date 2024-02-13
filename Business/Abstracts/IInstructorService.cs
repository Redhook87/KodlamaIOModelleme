using KodlamaIoModelleme.Business.Dtos.Requests.Instructor;
using KodlamaIoModelleme.Business.Dtos.Responses.Instructor;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface IInstructorService
{
    void Add(CreateInstructorRequest instructor);
    void Delete(DeleteInstructorRequest instructor);
    void Update(UpdateInstructorRequest instructor);
    List<GetAllInstructorResponse> GetAll();
    List<GetByIdInstructorResponse> GetById(int id);
}
