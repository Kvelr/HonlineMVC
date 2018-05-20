using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dal;
using HonlineCoreMVC.Common.Entities;
using Microsoft.AspNetCore.Identity;

namespace Bl
{
    public class CustomerLogic
    {
        public CustomerLogic()
        {
            _dal = new DataManager();
        }

        private readonly DataManager _dal;

        public ApplicationUser GetUserByID(string userId)
        {
            return _dal.GetUserByID(userId);
        }

        public List<ApplicationUser> GetApplicationUsers()
        {
            return _dal.GetAllApplicationUsers();
        }
    }
}
