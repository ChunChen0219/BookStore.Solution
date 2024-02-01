using BookStore.Models.Dtos;
using BookStore.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Interfaces
{
    public interface IUsedBookRepository
    {
        List<UsedBookDto> Search(string email, string ISBN);

    }
}
