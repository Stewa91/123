using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WeatherXParticulate, HasIndexInData = false)]
    public class WeatherXParticulateEntry
    {
        public int FileDataId { get; set; }
        public int ParentWeatherId { get; set; }
    }
}