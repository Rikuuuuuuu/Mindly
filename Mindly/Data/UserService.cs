using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Mindly.Models;

namespace Mindly.Data
{
    public class UserService
    {
        MindlyContext _context;
        public UserService(MindlyContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _context.User.ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(string id)
        {
            return await _context.User.FindAsync(id);
        }

        public async Task<User> InsertUserAsync(User User)
        {
            _context.User.Add(User);
            await _context.SaveChangesAsync();

            return User;
        }

        public async Task<User> UpdateUserAsync(string id, User s)
        {
            var User = await _context.User.FindAsync(id);

            if (User == null)
                return null;

            User.Email = s.Email;
            User.Password = s.Password;

            _context.User.Update(User);
            await _context.SaveChangesAsync();

            return User;
        }

        public async Task<User> DeleteUserAsync(string id)
        {
            var user = await _context.User.FindAsync(id);

            if (user == null)
                return null;

            _context.User.Remove(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private bool UserExists(int id)
        {
            return _context.User.Any(e => e.ID == id);
        }
    }
}