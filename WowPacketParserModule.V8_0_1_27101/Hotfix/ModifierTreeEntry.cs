using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ModifierTree, HasIndexInData = false)]
    public class ModifierTreeEntry
    {
        public int Parent { get; set; }
        public byte Operator { get; set; }
        public byte Amount { get; set; }
        public byte Type { get; set; }
        public uint Asset { get; set; }
        public int SecondaryAsset { get; set; }
        public byte TertiaryAsset { get; set; }
    }
}