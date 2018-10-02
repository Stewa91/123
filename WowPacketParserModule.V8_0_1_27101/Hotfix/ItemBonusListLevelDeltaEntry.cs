using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemBonusListLevelDelta)]
    public class ItemBonusListLevelDeltaEntry
    {
        public int ID { get; set; }
        public ushort ItemLevelDelta { get; set; }
    }
}