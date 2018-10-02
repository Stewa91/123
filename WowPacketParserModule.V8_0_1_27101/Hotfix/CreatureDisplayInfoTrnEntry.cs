using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureDisplayInfoTrn, HasIndexInData = false)]
    public class CreatureDisplayInfoTrnEntry
    {
        public int DstCreatureDisplayInfoId { get; set; }
        public uint DissolveEffectId { get; set; }
        public uint StartVisualKitId { get; set; }
        public float MaxTime { get; set; }
        public int FinishVisualKitId { get; set; }
        public int SrcCreatureDisplayInfoId { get; set; }
    }
}