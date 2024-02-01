using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.Dtos
{
    public class KeywordDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }
    }
}