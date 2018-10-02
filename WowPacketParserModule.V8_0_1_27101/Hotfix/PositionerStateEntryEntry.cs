using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PositionerStateEntry, HasIndexInData = false)]
    public class PositionerStateEntryEntry
    {
        public float ParamA { get; set; }
        public float ParamB { get; set; }
        public uint CurveId { get; set; }
        public ushort SrcValType { get; set; }
        public ushort SrcVal { get; set; }
        public ushort DstValType { get; set; }
        public ushort DstVal { get; set; }
        public byte EntryType { get; set; }
        public byte Style { get; set; }
        public byte SrcType { get; set; }
        public byte DstType { get; set; }
    }
}