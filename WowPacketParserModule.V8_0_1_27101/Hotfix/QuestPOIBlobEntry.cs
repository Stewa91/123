using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.QuestPOIBlob)]
    public class QuestPOIBlobEntry
    {
        public int ID { get; set; }
        public ushort MapId { get; set; }
        public int UiMapId { get; set; }
        public byte NumPoints { get; set; }
        public uint QuestId { get; set; }
        public int ObjectiveIndex { get; set; }
        public int PlayerConditionId { get; set; }
    }
}