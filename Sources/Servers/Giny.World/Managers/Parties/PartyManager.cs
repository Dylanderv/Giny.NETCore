using Giny.Core.DesignPattern;
using Giny.Core.Extensions;
using Giny.World.Managers.Entities.Characters;
using System.Collections.Concurrent;

namespace Giny.World.Managers.Parties;

public class PartyManager : Singleton<PartyManager>
{
    private ConcurrentDictionary<int, Party> m_parties = new ConcurrentDictionary<int, Party>();

    public ClassicalParty CreateParty(Character leader)
    {
        var party = new ClassicalParty(PopId(), leader);
        m_parties.TryAdd(party.Id, party);
        return party;
    }

    private int PopId()
    {
        if (m_parties.Count == 0)
        {
            return 1;
        }
        else
        {
            return m_parties.Keys.OrderByDescending(x => x).First() + 1;
        }
    }
    public void Remove(Party party)
    {
        m_parties.TryRemove(party.Id);
    }

    public Party GetParty(int partyId)
    {
        Party result = null;
        m_parties.TryGetValue(partyId, out result);
        return result;
    }
}