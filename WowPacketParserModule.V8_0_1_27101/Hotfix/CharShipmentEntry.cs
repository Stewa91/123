using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CharShipment, HasIndexInData = false)]
    public class CharShipmentEntry
    {
        public ushort ContainerId { get; set; }
        public int DummyItemId { get; set; }
        public int TreasureId { get; set; }
        public int SpellId { get; set; }
        public int OnCompleteSpellId { get; set; }
        public int Duration { get; set; }
        public byte MaxShipments { get; set; }
        public ushort GarrFollowerId { get; set; }
        public byte Flags { get; set; }
    }
}