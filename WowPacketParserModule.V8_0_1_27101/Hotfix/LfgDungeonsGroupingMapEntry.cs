using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.LfgDungeonsGroupingMap, HasIndexInData = false)]
    public class LfgDungeonsGroupingMapEntry
    {
        public ushort RandomLfgDungeonsId { get; set; }
        public byte GroupId { get; set; }
        public ushort LfgDungeonsId { get; set; }
    }
}