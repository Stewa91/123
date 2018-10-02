using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PositionerState, HasIndexInData = false)]
    public class PositionerStateEntry
    {
        public uint NextStateId { get; set; }
        public uint TransformMatrixId { get; set; }
        public uint PosEntryId { get; set; }
        public uint RotEntryId { get; set; }
        public uint ScaleEntryId { get; set; }
        public int Flags { get; set; }
        public float EndLife { get; set; }
        public byte EndLifePercent { get; set; }
    }
}