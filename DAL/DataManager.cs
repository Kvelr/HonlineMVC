using HonlineCoreMVC.Common.Entities;
using HonlineCoreMVC.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class DataManager
    {
        public DataManager()
        {
            _optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        }
        private readonly DbContextOptionsBuilder<ApplicationDbContext> _optionsBuilder;

        public ApplicationUser GetUserByID(string userId)
        {
            using (var _dbContext = new ApplicationDbContext(_optionsBuilder.Options))
            {
                return _dbContext.Users.FirstOrDefault(u => u.Id == userId);
            }
        }

        public List<ApplicationUser> GetAllApplicationUsers()
        {
            using (var _dbContext = new ApplicationDbContext(_optionsBuilder.Options))
            {
                return _dbContext.Users.ToList();
            }
        }
    }
}
