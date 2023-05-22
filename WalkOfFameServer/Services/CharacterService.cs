using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models.Characters;

namespace WalkOfFameServer.Services
{
    public class CharacterService
    {
        private readonly MainDbContext _context;
        
        public CharacterService(MainDbContext context)
        {
            _context = context;
        }
        
        public async Task<Character> Create(Character character)
        {
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();

            return character;
        }
        
        public async Task<Character?> GetById(Guid id)
        {
            return await _context.Characters.FindAsync(id);
        }

        public async Task<List<Character>> GetByUserId(Guid id)
        {
            return await _context.Characters.Where(c => c.User.Id.Equals(id)).ToListAsync();
        }
    }
}
