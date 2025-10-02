using Giny.Core.IO.Interfaces;

namespace Giny.Protocol.Types;

public class TreasureHuntStepDig : TreasureHuntStep
{
    public new const ushort Id = 6844;
    public override ushort TypeId => Id;


    public TreasureHuntStepDig()
    {
    }
    public override void Serialize(IDataWriter writer)
    {
    }
    public override void Deserialize(IDataReader reader)
    {
    }


}