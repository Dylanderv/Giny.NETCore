using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class TreasureHuntStepFight : TreasureHuntStep
{
    public new const ushort Id = 3707;
    public override ushort TypeId => Id;


    public TreasureHuntStepFight()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }


}