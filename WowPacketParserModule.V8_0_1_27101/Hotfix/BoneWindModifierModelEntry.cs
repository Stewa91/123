using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.BoneWindModifierModel, HasIndexInData = false)]
    public class BoneWindModifierModelEntry
    {
        public int FileDataId { get; set; }
        public int BoneWindModifierId { get; set; }
    }
}