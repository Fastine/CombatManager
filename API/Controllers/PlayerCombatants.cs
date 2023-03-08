using API.Data;
using API.Entities;
using API.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class PlayerCombatantsController : BaseApiController
    {
        private readonly IPlayerCombatantRepository _playerCombatantRepository;
        public PlayerCombatantsController(IPlayerCombatantRepository playerCombatantRepository)
        {
            _playerCombatantRepository = playerCombatantRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PlayerCombatant>>> GetPlayerCombatants()
        {
            return Ok(await _playerCombatantRepository.GetPlayerCombatantsAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<PlayerCombatant>> GetPlayerCombatant(int id)
        {
            return Ok(await _playerCombatantRepository.GetPlayerCombatantByIdAsync(id));
        }

        [HttpGet("{name}")]
        public async Task<ActionResult<PlayerCombatant>> GetPlayerCombatantByNameAsync(string name)
        {
            return Ok(await _playerCombatantRepository.GetPlayerCombatantByNameAsync(name));
        }





    }
}