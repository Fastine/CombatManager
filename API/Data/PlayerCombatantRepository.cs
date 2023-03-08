using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class PlayerCombatantRepository : IPlayerCombatantRepository
    {
        private readonly DataContext _context;
        public PlayerCombatantRepository(DataContext context)
        {
            _context = context;

        }
        public async Task<PlayerCombatant> GetPlayerCombatantByIdAsync(int id)
        {
            return await _context.PlayerCombatants.FindAsync(id);
        }

        public async Task<PlayerCombatant> GetPlayerCombatantByNameAsync(string name)
        {
            return await _context.PlayerCombatants.SingleOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<PlayerCombatant>> GetPlayerCombatantsAsync()
        {
            return await _context.PlayerCombatants.ToListAsync();
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(PlayerCombatant playerCombatant)
        {
            _context.Entry(playerCombatant).State = EntityState.Modified;
        }
    }
}