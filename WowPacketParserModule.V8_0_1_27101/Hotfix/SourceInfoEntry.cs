using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SourceInfo, HasIndexInData = false)]
    public class SourceInfoEntry
    {
        public string SourceText { get; set; }
        public byte PvpFaction { get; set; }
        public byte SourceTypeEnum { get; set; }
        public int SpellId { get; set; }
    }
}