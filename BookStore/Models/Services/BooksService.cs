using BookStore.Models.Dtos;
using BookStore.Models.Interfaces;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models.Services
{
    public class BooksService
    {
        private IBooksRepository _repos;

        public BooksService(IBooksRepository repos)
        {
            _repos = repos;
        }

        public void Create(BooksDto dto)
        {
            _repos.Create(dto);
        }
        public List<BooksIndexVm> Search()
        {
            var dtos = _repos.Search();
            var vms = dtos.Select(x => new BooksIndexVm()
            {
                Id = x.Id,
                CategoryName = x.CategoryName,
                Author = x.Author,
                Language = x.Language,
                Name = x.Name
            }).ToList();

            return vms;
        }
    }
}