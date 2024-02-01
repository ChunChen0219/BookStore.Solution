using BookStore.Models.Exts;
using BookStore.Models.Interfaces;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BookStore.Models.Services
{
    public class UsedBookService
    {
        private IUsedBookRepository _repos;
        public UsedBookService(IUsedBookRepository repos) 
        { 
            _repos = repos; 
        }
        public List<UsedBookIndexVm> Search(string email,string ISBN)
        {
            return _repos.Search(email,ISBN)
                        .Select(x => x.ToUsedBookIndexVm())
                        .ToList();
        }
    }
}