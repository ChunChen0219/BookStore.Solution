using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.Dtos
{
    public class UsedBookDto
    {
        public int Id { get; set; }

        public int MemberId { get; set; }

        public string MemberEmail { get; set; }

        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public bool ProductStatus { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string ISBN { get; set; }

        public string Pictrue { get; set; }

        public string BookStatus { get; set; }
    }
}