using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrTalentTree, HasIndexInData = false)]
    public class GarrTalentTreeEntry
    {
        public int GarrTypeId { get; set; }
        public int ClassId { get; set; }
        public byte MaxTiers { get; set; }
        public byte UiOrder { get; set; }
        public ushort UiTextureKitId { get; set; }
    }
}