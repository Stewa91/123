using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.ObjectEffect, HasIndexInData = false)]
    public class ObjectEffectEntry
    {
        [HotfixArray(3)]
        public float[] Offset { get; set; }
        public ushort ObjectEffectGroupId { get; set; }
        public byte TriggerType { get; set; }
        public byte EventType { get; set; }
        public byte EffectRecType { get; set; }
        public int EffectRecId { get; set; }
        public byte Attachment { get; set; }
        public int ObjectEffectModifierId { get; set; }
    }
}