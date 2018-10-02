using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.UiMapXMapArt, HasIndexInData = false)]
    public class UiMapXMapArtEntry
    {
        public int PhaseId { get; set; }
        public int UiMapArtId { get; set; }
        public int UiMapId { get; set; }
    }
}