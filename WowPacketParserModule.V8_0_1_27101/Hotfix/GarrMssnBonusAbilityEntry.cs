using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GarrMssnBonusAbility, HasIndexInData = false)]
    public class GarrMssnBonusAbilityEntry
    {
        public byte GarrFollowerTypeId { get; set; }
        public byte GarrMissionTextureId { get; set; }
        public ushort GarrAbilityId { get; set; }
        public float Radius { get; set; }
        public int DurationSecs { get; set; }
    }
}