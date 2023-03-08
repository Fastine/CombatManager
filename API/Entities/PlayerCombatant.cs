namespace API.Entities
{
    public class PlayerCombatant
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }
        public int InitiativeBonus { get; set; }
        public int ArmorClass { get; set; }
    }
}