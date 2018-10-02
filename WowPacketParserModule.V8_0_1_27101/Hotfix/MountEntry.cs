using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Mount)]
    public class MountEntry
    {
        public string Name { get; set; }
        public string SourceText { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public ushort MountTypeId { get; set; }
        public ushort Flags { get; set; }
        public byte SourceTypeEnum { get; set; }
        public int SourceSpellId { get; set; }
        public int PlayerConditionId { get; set; }
        public float MountFlyRideHeight { get; set; }
        public int UiModelSceneId { get; set; }
    }
}