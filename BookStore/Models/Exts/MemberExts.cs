using BookStore.Models.EFModels;
using BookStore.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.Exts
{
    public static class MemberExts
    {
        public static MemberVm ToEditProfileVm(this Member member)
        {
            return new MemberVm
            {
                Id = member.Id,
                Name = member.Name,
                Gender = member.Gender,
                DateOfBirth = member.DateOfBirth,
                Email = member.Email,
                Password = member.Password,
                MembersLevel = member.MembersLevel,
                Address = member.Address,
                PhoneNumber = member.PhoneNumber,
                Points = member.Points,


            };
        }
    }
}