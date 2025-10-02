using Giny.Core.IO.Interfaces;
using Giny.IO.D2O;

namespace Giny.IO.D2OClasses;

[D2OClass("MountBehavior", "")]
public class MountBehavior : IDataObject, IIndexedData
{
    public const string MODULE = "MountBehaviors";

    public int Id => (int)id;

    public uint id;
    public uint nameId;
    public uint descriptionId;

    [D2OIgnore]
    public uint Id_
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
    [D2OIgnore]
    public uint DescriptionId
    {
        get
        {
            return descriptionId;
        }
        set
        {
            descriptionId = value;
        }
    }

}