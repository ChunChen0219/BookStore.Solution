using BookStore.Models.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.ViewModels
{
    public class KeywordIndexVm
    {
        public int Id { get; set; }

        [Display(Name = "關鍵詞名稱")]        
        public string Name { get; set; }
    }
}