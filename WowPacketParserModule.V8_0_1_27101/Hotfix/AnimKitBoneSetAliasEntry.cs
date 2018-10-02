using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.AnimKitBoneSetAlias, HasIndexInData = false)]
    public class AnimKitBoneSetAliasEntry
    {
        public byte BoneDataId { get; set; }
        public byte AnimKitBoneSetId { get; set; }
    }
}