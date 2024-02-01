using BookStore.Models.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.ViewModels
{
    public class BooksCreateVm
    {
        public int Id { get; set; }

        [Display(Name = "分類")]
        [Required(ErrorMessage =DAHelper.Required)]
        public int CategoryID { get; set; }

        [Display(Name = "作者")]
        [Required(ErrorMessage = DAHelper.Required)]
        [StringLength(50,ErrorMessage =DAHelper.StringLength)]
        public string Author { get; set; }

        [Display(Name = "描述")]
        [Required(ErrorMessage = DAHelper.Required)]
        public string Description { get; set; }

        [Display(Name = "語言")]
        [Required(ErrorMessage = DAHelper.Required)]
        [StringLength(50, ErrorMessage = DAHelper.StringLength),]
        public string Language { get; set; }

        [Display(Name = "名稱")]
        [Required(ErrorMessage = DAHelper.Required)]
        [StringLength(50, ErrorMessage = DAHelper.StringLength)]
        public string Name { get; set; }
    }
}