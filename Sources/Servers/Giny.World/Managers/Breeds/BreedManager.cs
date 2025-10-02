using Giny.Core.DesignPattern;
using Giny.World.Managers.Entities.Characters;
using Giny.World.Managers.Entities.Look;
using Giny.World.Records.Breeds;

namespace Giny.World.Managers.Breeds;

public class BreedManager : Singleton<BreedManager>
{
    public const short BreedDefaultLife = 55;

    public const short BreedDefaultProspecting = 100;
      

    public ServerEntityLook GetBreedLook(BreedRecord breedRecord, bool sex, short cosmeticId, int[] colors)
    {
        ServerEntityLook result = sex ? breedRecord.FemaleLook.Clone() : breedRecord.MaleLook.Clone();

        result.AddSkin(HeadRecord.GetSkinId(cosmeticId));

        int[] simpleColors = VerifiyColors(colors, sex, breedRecord);

        result.SetColors(EntityLookManager.Instance.GetConvertedColors(simpleColors));

        return result;
    }
    public static int[] VerifiyColors(IEnumerable<int> colors, bool sex, BreedRecord breedRecord)
    {
        int[] defaultColors = sex ? breedRecord.FemaleColors : breedRecord.MaleColors;

        if (colors.Count() == 0)
        {
            return defaultColors.ToArray();
        }

        int num = 0;

        List<int> simpleColors = new List<int>();
        foreach (int current in colors)
        {
            if (defaultColors.Length > num)
            {
                simpleColors.Add((current == -1) ? (int)defaultColors[num] : current);
            }
            num++;
        }

        return simpleColors.ToArray();
    }

    public void LearnBreedSpells(Character character)
    {
        character.LearnSpell(0, false);

        foreach (var spell in character.Breed.Spells)
        {
            character.LearnSpell(spell.Id, false);
        }
    }
}