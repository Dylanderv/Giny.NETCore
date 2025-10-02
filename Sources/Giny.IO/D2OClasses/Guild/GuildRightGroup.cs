using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("GuildRightGroup", "")]
public class GuildRightGroup : SocialRightGroup, IIndexedData
{
    public const string MODULE = "GuildRightGroups";

    public int Id => throw new NotImplementedException();



}