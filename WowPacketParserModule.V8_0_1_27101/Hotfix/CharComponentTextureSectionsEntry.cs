using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharComponentTextureSections, HasIndexInData = false)]
    public class CharComponentTextureSectionsEntry
    {
        public byte CharComponentTextureLayoutId { get; set; }
        public byte SectionType { get; set; }
        public ushort X { get; set; }
        public ushort Y { get; set; }
        public ushort Width { get; set; }
        public ushort Height { get; set; }
        public int OverlapSectionMask { get; set; }
    }
}