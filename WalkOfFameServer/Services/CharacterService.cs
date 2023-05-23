using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdGen;
using Microsoft.EntityFrameworkCore;
using WalkOfFameServer.Database;
using WalkOfFameServer.Models.Characters;

namespace WalkOfFameServer.Services
{
    public class CharacterService
    {
        private readonly MainDbContext _context;
        private readonly IdGenerator _idGenerator;
        
        public CharacterService(MainDbContext context, IdGenerator idGenerator)
        {
            _context = context;
            _idGenerator = idGenerator;
        }
        
        public async Task<Character> Create(Character character)
        {
            character.Id = _idGenerator.CreateId();
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();

            return character;
        }
        
        public async Task<Character?> GetById(long id)
        {
            return await _context.Characters.FindAsync(id);
        }

        public async Task<List<Character>> GetAllByUserId(long id)
        {
            return await _context.Characters.Where(c => c.User.Id.Equals(id)).ToListAsync();
        }
    }
}
