using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Models;

namespace WalkOfFameServer.Database.Repositories
{
    public class UserRepository
    {
        private readonly MainDbContext _context;

        public UserRepository(MainDbContext context)
        {
            _context = context;
        }

        public async Task<User> Create(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
        
        public async Task<User?> GetById(int id)
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
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == name && u.Password == password);
        }
    }
}
