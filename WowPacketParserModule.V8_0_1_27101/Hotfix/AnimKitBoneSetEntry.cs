using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AnimKitBoneSet, HasIndexInData = false)]
    public class AnimKitBoneSetEntry
    {
        public string Name { get; set; }
        public byte BoneDataId { get; set; }
        public byte ParentAnimKitBoneSetId { get; set; }
        public byte ExtraBoneCount { get; set; }
        public byte AltAnimKitBoneSetId { get; set; }
    }
}