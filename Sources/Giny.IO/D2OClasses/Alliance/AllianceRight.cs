using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("AllianceRight", "")]
public class AllianceRight : SocialRight, IIndexedData
{
    public const string MODULE = "AllianceRights";

    public int Id => throw new NotImplementedException();



}