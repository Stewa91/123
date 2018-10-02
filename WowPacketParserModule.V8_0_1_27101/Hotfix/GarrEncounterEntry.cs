using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrEncounter)]
    public class GarrEncounterEntry
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int CreatureId { get; set; }
        public int PortraitFileDataId { get; set; }
        public uint UiTextureKitId { get; set; }
        public float UiAnimScale { get; set; }
        public float UiAnimHeight { get; set; }
    }
}