using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("SocialTagsType", "")]
public class SocialTagsType : IDataObject, IIndexedData
{

    public int Id => (int)id;

    public int id;
    public uint nameId;

    [D2OIgnore]
    public int Id_
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
    [D2OIgnore]
    public uint NameId
    {
        get
        {
            return nameId;
        }
        set
        {
            nameId = value;
        }
    }

}