using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MountCapability)]
    public class MountCapabilityEntry
    {
        public int ID { get; set; }
        public byte Flags { get; set; }
        public ushort ReqRidingSkill { get; set; }
        public ushort ReqAreaId { get; set; }
        public int ReqSpellAuraId { get; set; }
        public int ReqSpellKnownId { get; set; }
        public int ModSpellAuraId { get; set; }
        public ushort ReqMapId { get; set; }
    }
}