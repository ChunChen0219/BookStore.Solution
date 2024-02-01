using BookStore.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models.ViewModels
{
    public class GroupEditVm
    {
        public int GroupId { get; set; }
        public List<GroupFunction> CanChooseFunctions { get; set; }
        public List<GroupFunction> AllFunctions { get; set; }


        public GroupEditVm()
        {
            CanChooseFunctions = new List<GroupFunction>();

            AllFunctions = new List<GroupFunction>();
            
        }
    }
}