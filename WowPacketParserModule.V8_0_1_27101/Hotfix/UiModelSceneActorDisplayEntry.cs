using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiModelSceneActorDisplay, HasIndexInData = false)]
    public class UiModelSceneActorDisplayEntry
    {
        public uint AnimationId { get; set; }
        public uint SequenceVariation { get; set; }
        public float Alpha { get; set; }
        public float Scale { get; set; }
        public float AnimSpeed { get; set; }
    }
}