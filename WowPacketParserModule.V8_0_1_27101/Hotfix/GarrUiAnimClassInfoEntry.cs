using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrUiAnimClassInfo, HasIndexInData = false)]
    public class GarrUiAnimClassInfoEntry
    {
        public byte GarrClassSpecId { get; set; }
        public byte MovementType { get; set; }
        public float ImpactDelaySecs { get; set; }
        public int CastKit { get; set; }
        public int ImpactKit { get; set; }
        public int TargetImpactKit { get; set; }
    }
}