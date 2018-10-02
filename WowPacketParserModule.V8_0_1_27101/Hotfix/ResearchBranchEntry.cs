using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ResearchBranch, HasIndexInData = false)]
    public class ResearchBranchEntry
    {
        public string Name { get; set; }
        public byte ResearchFieldId { get; set; }
        public ushort CurrencyId { get; set; }
        public int TextureFileId { get; set; }
        public int BigTextureFileId { get; set; }
        public int ItemId { get; set; }
    }
}