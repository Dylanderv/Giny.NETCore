using Giny.World.Api;
using Giny.World.Modules;

namespace Giny.Pokefus;

[Module("Pokéfus")]
public class Module : IModule
{
    public void Initialize()
    {
        PokefusWishManager.Initialize();
        PokefusManager.Instance.Initialize();
    }

    public void CreateHooks()
    {
        FightEventApi.OnPlayerResultApplied += PokefusManager.Instance.OnPlayerResultApplied;
        // CharacterEventApi.OnHumanOptionsCreated += PokefusManager.Instance.OnHumanOptionsCreated;
        FightEventApi.OnFighterJoined += PokefusManager.Instance.OnFighterJoined;
        InventoryEventApi.CanEquipItem += PokefusManager.Instance.CanEquipItem;
        FightEventApi.OnSpellCasting += PokefusManager.Instance.OnSpellCasting;
        InventoryEventApi.OnItemEquipped += PokefusManager.Instance.OnItemEquipped;
        InventoryEventApi.OnItemUnequipped += PokefusManager.Instance.OnItemUnequipped;
    }

    public void Dispose()
    {

    }
}