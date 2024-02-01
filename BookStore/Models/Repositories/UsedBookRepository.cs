using BookStore.Models.Dtos;
using BookStore.Models.EFModels;
using BookStore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using System.Web.Helpers;

namespace BookStore.Models.Repositories
{
    public class UsedBookRepository : IUsedBookRepository
    {
        public List<UsedBookDto> Search(string email,string ISBN)
        {
            var db = new AppDbContext();

            var model = db.UsedBooks
                            .AsNoTracking()
                            .Include(x => x.Member)
                            .Select(x => new UsedBookDto()
                            {
                                Id = x.Id,
                                MemberId = x.MemberId,
                                MemberEmail = x.Member.Email,
                                CategoryId = x.CategoryId,
                                CategoryName = x.Category.Name, 
                                ProductStatus = x.ProductStatus, 
                                Price =x.Price,
                                Description=x.Description ,
                                ISBN =x.ISBN,
                                Pictrue =x.Pictrue,
                                BookStatus = x.BookStatus 
                            });

            model = ConditionalFiltering(model,email,ISBN);

            return model.ToList();
        }

        //條件篩選
        public IQueryable<UsedBookDto> ConditionalFiltering(IQueryable<UsedBookDto> model,string email,string ISBN)
        {
            if (!string.IsNullOrEmpty(email))
            {
                model = model.Where(p => p.MemberEmail.Contains(email));
            }

            if (!string.IsNullOrEmpty(ISBN))
            {
                model = model.Where(p => p.ISBN.Contains(ISBN));
            }
            return model;
        } 
    }
}