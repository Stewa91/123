using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisualMissile)]
    public class SpellVisualMissileEntry
    {
        [HotfixArray(3)]
        public float[] CastOffset { get; set; }
        [HotfixArray(3)]
        public float[] ImpactOffset { get; set; }
        public int ID { get; set; }
        public ushort SpellVisualEffectNameId { get; set; }
        public int SoundEntriesId { get; set; }
        public byte Attachment { get; set; }
        public byte DestinationAttachment { get; set; }
        public ushort CastPositionerId { get; set; }
        public ushort ImpactPositionerId { get; set; }
        public uint FollowGroundHeight { get; set; }
        public int FollowGroundDropSpeed { get; set; }
        public ushort FollowGroundApproach { get; set; }
        public int Flags { get; set; }
        public ushort SpellMissileMotionId { get; set; }
        public int AnimKitId { get; set; }
        public ushort SpellVisualMissileSetId { get; set; }
    }
}