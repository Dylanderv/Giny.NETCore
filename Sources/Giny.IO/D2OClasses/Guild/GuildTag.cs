using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("GuildTag", "")]
public class GuildTag : SocialTag, IIndexedData
{
    public const string MODULE = "GuildTags";

    public int Id => throw new NotImplementedException();



}