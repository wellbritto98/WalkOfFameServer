using System;
using System.Threading.Tasks;
using IdGen;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models.Users;

namespace WalkOfFameServer.Services
{
    public class UserService
    {
        private readonly MainDbContext _context;
        private readonly UtilsService _utils;
        private readonly IdGenerator _idGenerator;

        public UserService(MainDbContext context, UtilsService utils, IdGenerator idGenerator)
        {
            _context = context;
            _utils = utils;
            _idGenerator = idGenerator;
        }
        
        public async Task<User> Create(User user)
        {
            user.Id = _idGenerator.CreateId();
            user.Password = _utils.HashSha512(user.Password);
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
        
        public async Task<User?> GetById(long id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User?> GetByUserName(string name)
        {
            return await _context.Users.FirstOrDefaultAsync(m => m.UserName == name);
        }
        
        public async Task<User?> GetByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(m => m.Email == email);
        }

        public async Task<User?> GetByUserNameAndPassword(string name, string password)
        {
            var hashedPassword = _utils.HashSha512(password);
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == name && u.Password == hashedPassword);
        }
    }
}
