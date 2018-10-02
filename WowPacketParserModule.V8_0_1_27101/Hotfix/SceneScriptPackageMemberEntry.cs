using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SceneScriptPackageMember, HasIndexInData = false)]
    public class SceneScriptPackageMemberEntry
    {
        public ushort SceneScriptPackageId { get; set; }
        public ushort SceneScriptId { get; set; }
        public ushort ChildSceneScriptPackageId { get; set; }
        public byte OrderIndex { get; set; }
    }
}