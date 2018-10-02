using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ArtifactCategory, HasIndexInData = false)]
    public class ArtifactCategoryEntry
    {
        public ushort XpMultCurrencyId { get; set; }
        public ushort XpMultCurveId { get; set; }
    }
}