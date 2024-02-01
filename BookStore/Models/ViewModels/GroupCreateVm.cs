using BookStore.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models.ViewModels
{
    public class GroupCreateVm
    {
        public string GroupName { get; set; } 
        public List<GroupFunction> AllFunctions { get; set; } 
        public List<int> SelectedFunctions { get; set; } 


        public GroupCreateVm()
        {
            AllFunctions = new List<GroupFunction>();
            SelectedFunctions = new List<int>();
        }
    }
}