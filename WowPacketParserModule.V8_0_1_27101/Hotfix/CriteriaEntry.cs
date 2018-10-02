using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Criteria, HasIndexInData = false)]
    public class CriteriaEntry
    {
        public ushort Type { get; set; }
        public int Asset { get; set; }
        public int ModifierTreeId { get; set; }
        public byte StartEvent { get; set; }
        public int StartAsset { get; set; }
        public ushort StartTimer { get; set; }
        public byte FailEvent { get; set; }
        public int FailAsset { get; set; }
        public byte Flags { get; set; }
        public ushort EligibilityWorldStateId { get; set; }
        public byte EligibilityWorldStateValue { get; set; }
    }
}