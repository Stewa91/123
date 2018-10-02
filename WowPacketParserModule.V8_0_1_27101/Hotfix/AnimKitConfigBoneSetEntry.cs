using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AnimKitConfigBoneSet, HasIndexInData = false)]
    public class AnimKitConfigBoneSetEntry
    {
        public byte AnimKitBoneSetId { get; set; }
        public ushort AnimKitPriorityId { get; set; }
        public ushort ParentAnimKitConfigId { get; set; }
    }
}