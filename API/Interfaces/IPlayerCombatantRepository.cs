using API.Entities;

namespace API.Interfaces
{
    public interface IPlayerCombatantRepository
    {
        void Update(PlayerCombatant playerCombatant);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<PlayerCombatant>> GetPlayerCombatantsAsync();
        Task<PlayerCombatant> GetPlayerCombatantByIdAsync(int id);
        Task<PlayerCombatant> GetPlayerCombatantByNameAsync(string name);
    }
}