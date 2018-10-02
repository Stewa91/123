using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisualKitModelAttach)]
    public class SpellVisualKitModelAttachEntry
    {
        [HotfixArray(3)]
        public float[] Offset { get; set; }
        [HotfixArray(3)]
        public float[] OffsetVariation { get; set; }
        public int ID { get; set; }
        public ushort SpellVisualEffectNameId { get; set; }
        public sbyte AttachmentId { get; set; }
        public ushort PositionerId { get; set; }
        public float Yaw { get; set; }
        public float Pitch { get; set; }
        public float Roll { get; set; }
        public float YawVariation { get; set; }
        public float PitchVariation { get; set; }
        public float RollVariation { get; set; }
        public float Scale { get; set; }
        public float ScaleVariation { get; set; }
        public ushort StartAnimId { get; set; }
        public ushort AnimId { get; set; }
        public ushort EndAnimId { get; set; }
        public ushort AnimKitId { get; set; }
        public byte Flags { get; set; }
        public int LowDefModelAttachId { get; set; }
        public float StartDelay { get; set; }
        public int ParentSpellVisualKitId { get; set; }
    }
}