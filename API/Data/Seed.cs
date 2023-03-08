using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedPlayerCombatants(DataContext context)
        {
            if (await context.PlayerCombatants.AnyAsync()) return;

            var playerCombatantData = await File.ReadAllTextAsync("Data/PlayerCombatantSeedData.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var playerCombatants = JsonSerializer.Deserialize<List<PlayerCombatant>>(playerCombatantData);

            foreach (var playerCombatant in playerCombatants)
            {
                playerCombatant.CurrentHitPoints = playerCombatant.MaxHitPoints;

                context.PlayerCombatants.Add(playerCombatant);
            }

            await context.SaveChangesAsync();
        }
    }
}