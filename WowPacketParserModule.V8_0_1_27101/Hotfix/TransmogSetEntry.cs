using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.TransmogSet)]
    public class TransmogSetEntry
    {
        public string Name { get; set; }
        public uint ID { get; set; }
        public int ClassMask { get; set; }
        public int TrackingQuestId { get; set; }
        public int Flags { get; set; }
        public int TransmogSetGroupId { get; set; }
        public int ItemNameDescriptionId { get; set; }
        public ushort ParentTransmogSetId { get; set; }
        public byte ExpansionId { get; set; }
        public ushort UiOrder { get; set; }
    }
}