using BookStore.Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Interfaces
{
    public interface IBooksRepository
    {
        void Create(BooksDto entity);

        List<BooksDto> Search();
    }
}
