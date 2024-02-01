using BookStore.Models.Dtos;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace BookStore.Models.Exts
{
    public static class UsedBookExts
    {
        public static UsedBookIndexVm ToUsedBookIndexVm(this UsedBookDto dto)
        {
            return new UsedBookIndexVm()
            {            
                MemberEmail = dto.MemberEmail,
                CategoryName = dto.CategoryName,
                ProductStatus = dto.ProductStatus ,
                Price = dto.Price,
                ISBN = dto.ISBN,      
                BookStatus = dto.BookStatus 
            };
        }
    }
}