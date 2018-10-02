using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PowerType, HasIndexInData = false)]
    public class PowerTypeEntry
    {
        public string NameGlobalStringTag { get; set; }
        public string CostGlobalStringTag { get; set; }
        public byte PowerTypeEnum { get; set; }
        public byte MinPower { get; set; }
        public ushort MaxBasePower { get; set; }
        public byte CenterPower { get; set; }
        public byte DefaultPower { get; set; }
        public byte DisplayModifier { get; set; }
        public ushort RegenInterruptTimeMS { get; set; }
        public float RegenPeace { get; set; }
        public float RegenCombat { get; set; }
        public ushort Flags { get; set; }
    }
}