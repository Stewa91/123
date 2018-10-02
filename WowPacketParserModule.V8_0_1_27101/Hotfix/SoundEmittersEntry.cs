using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SoundEmitters)]
    public class SoundEmittersEntry
    {
        public string Name { get; set; }
        [HotfixArray(3)]
        public float[] Position { get; set; }
        [HotfixArray(3)]
        public float[] Direction { get; set; }
        public int ID { get; set; }
        public int SoundEntriesId { get; set; }
        public ushort WorldStateExpressionId { get; set; }
        public byte EmitterType { get; set; }
        public ushort PhaseId { get; set; }
        public int PhaseGroupId { get; set; }
        public byte PhaseUseFlags { get; set; }
        public byte Flags { get; set; }
        public short MapId { get; set; }
    }
}