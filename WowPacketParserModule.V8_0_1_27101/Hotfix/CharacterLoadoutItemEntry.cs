using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharacterLoadoutItem, HasIndexInData = false)]
    public class CharacterLoadoutItemEntry
    {
        public ushort CharacterLoadoutId { get; set; }
        public int ItemId { get; set; }
    }
}