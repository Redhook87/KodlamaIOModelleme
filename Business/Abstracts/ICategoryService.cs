using KodlamaIoModelleme.Business.Dtos.Requests.Category;
using KodlamaIoModelleme.Business.Dtos.Responses.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoModelleme.Business.Abstracts;

public interface ICategoryService
{
    void Add(CreateCategoryRequest category);//request
    void Delete(DeleteCategoryRequest category);
    void Update(UpdateCategoryRequest category);
    List<GetAllCategoryResponse> GetAll();//response
    List<GetByIdCategoryResponse> GetById(int id);
}
