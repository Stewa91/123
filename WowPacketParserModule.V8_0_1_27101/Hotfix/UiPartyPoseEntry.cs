using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiPartyPose, HasIndexInData = false)]
    public class UiPartyPoseEntry
    {
        public int VictoryUiModelSceneID;
        public int DefeatUiModelSceneID;
        public int VictorySoundKitID;
        public int DefeatSoundKitID;
        public int MapID;
    }
}