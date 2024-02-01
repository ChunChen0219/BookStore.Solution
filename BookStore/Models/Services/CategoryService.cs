using BookStore.Models.Dtos;
using BookStore.Models.EFModels;
using BookStore.Models.Exts;
using BookStore.Models.Interfaces;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models.Services
{
    public class CategoryService
    {
        private ICategoryRepository _repos;
        public CategoryService(ICategoryRepository repos) 
        {
            _repos = repos; 
        }
        public void Create(CategoryDto dto)
        {
            IsNameExist(dto.Name);
            _repos.Create(dto);
        }
        public void Delete(int id)
        {
            _repos.Delete(id);
        }
        public List<CategoryIndexVm> Search(string name) 
        {
            return _repos.Search(name)
                         .Select(x => x.ToCategoryIndexVm() )
                         .OrderBy(x => x.DisplayOrder)
                         .ToList();
        }

        public void Update(CategoryDto dto)
        {
            
            IsNameExist(dto.Name,dto.Id);
            _repos.Update(dto);
        }


        public CategoryVm Get(int id) 
        {
            return _repos.Get(id).ToCategoryVm();
        }

        //---------funciton---------
        private void IsNameExist(string name,int? id = -1)
        {
            var category = _repos.SearchFirstName(name);

            if (category.Id != null && id != category.Id) throw new Exception("分類名稱已重複");
        }
    }
}