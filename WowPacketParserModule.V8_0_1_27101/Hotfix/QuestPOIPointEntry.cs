using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.QuestPOIPoint)]
    public class QuestPOIPointEntry
    {
        public int ID { get; set; }
        public ushort X { get; set; }
        public ushort Y { get; set; }
        public int QuestPoiBlobId { get; set; }
    }
}
    