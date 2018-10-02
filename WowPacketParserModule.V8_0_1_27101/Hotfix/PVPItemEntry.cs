using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PvpItem, HasIndexInData = false)]
    public class PVPItemEntry
    {
        public int ItemId { get; set; }
        public byte ItemLevelDelta { get; set; }
    }
}