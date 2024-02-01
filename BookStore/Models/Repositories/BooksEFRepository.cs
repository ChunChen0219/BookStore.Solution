using BookStore.Models.Dtos;
using BookStore.Models.EFModels;
using BookStore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models.Repositories
{
    public class BooksEFRepository : IBooksRepository
    {
        public void Create(BooksDto dto)
        {
            var db = new AppDbContext();

            var model = new Book
            {
                Id = dto.Id,
                CategoryID = dto.CategoryId,
                Author = dto.Author,                
                Language = dto.Language
            };

            db.Books.Add(model);
            db.SaveChanges();
        }

        public List<BooksDto> Search()
        {
            var db = new AppDbContext();

            var model = db.Books
                          .AsNoTracking()
                          .Include(b => b.Category)
                          .Select(b => new BooksDto()
                          {
                              Id = b.Id,
                              CategoryId = b.CategoryID,
                              CategoryName = b.Category.Name,
                              Author = b.Author,                           
                              Language = b.Language,
                              Name = b.Name
                          })
                          .ToList();
            return model;
        }
    }
}