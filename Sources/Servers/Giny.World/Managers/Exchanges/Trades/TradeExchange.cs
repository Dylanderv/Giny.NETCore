using Giny.World.Managers.Entities.Characters;
using Giny.World.Records.Items;

namespace Giny.World.Managers.Exchanges.Trades;

public abstract class TradeExchange : Exchange
{
    protected TradeExchange(Character character) : base(character)
    {
    }

    public void TransferAllFromInventory()
    {
        foreach (var item in Character.Inventory.GetItems().Where(x => !x.IsEquiped()))
        {
            MoveItem(item.UId, item.Quantity);
        }
    }

    public void TransferAllToInventory()
    {
        foreach (var item in GetItems())
        {
            MoveItem(item.UId, -item.Quantity);
        }
    }

    public abstract IEnumerable<CharacterItemRecord> GetItems();

    // also MoveItem override here
}