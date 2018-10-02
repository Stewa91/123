using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.GameObjects)]
    public class GameObjectsEntry
    {
        public string Name { get; set; }
        [HotfixArray(3)]
        public float[] Pos { get; set; }
        [HotfixArray(4)]
        public float[] Rot { get; set; }
        public int ID { get; set; }
        public ushort OwnerId { get; set; }
        public ushort DisplayId { get; set; }
        public float Scale { get; set; }
        public byte TypeId { get; set; }
        public byte PhaseUseFlags { get; set; }
        public ushort PhaseId { get; set; }
        public ushort PhaseGroupId { get; set; }
        [HotfixArray(8)]
        public uint[] PropValue { get; set; }
    }
}