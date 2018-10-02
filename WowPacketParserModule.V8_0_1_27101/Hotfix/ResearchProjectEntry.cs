using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ResearchProject)]
    public class ResearchProjectEntry
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public byte Rarity { get; set; }
        public int SpellId { get; set; }
        public ushort ResearchBranchId { get; set; }
        public byte NumSockets { get; set; }
        public int TextureFileId { get; set; }
        public uint RequiredWeight { get; set; }
    }
}