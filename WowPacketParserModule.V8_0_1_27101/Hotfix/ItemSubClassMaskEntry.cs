using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ItemSubClassMask, HasIndexInData = false)]
    public class ItemSubClassMaskEntry
    {
        public string Name { get; set; }
        public byte ClassId { get; set; }
        public int Mask { get; set; }
    }
}