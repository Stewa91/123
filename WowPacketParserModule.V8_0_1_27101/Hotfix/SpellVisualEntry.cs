using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.SpellVisual, HasIndexInData = false)]
    public class SpellVisualEntry
    {
        [HotfixArray(3)]
        public float[] MissileCastOffset { get; set; }
        [HotfixArray(3)]
        public float[] MissileImpactOffset { get; set; }
        public int AnimEventSoundId { get; set; }
        public int Flags { get; set; }
        public sbyte MissileAttachment { get; set; }
        public sbyte MissileDestinationAttachment { get; set; }
        public uint MissileCastPositionerId { get; set; }
        public uint MissileImpactPositionerId { get; set; }
        public int MissileTargetingKit { get; set; }
        public uint HostileSpellVisualId { get; set; }
        public int CasterSpellVisualId { get; set; }
        public ushort SpellVisualMissileSetId { get; set; }
        public ushort DamageNumberDelay { get; set; }
        public int LowViolenceSpellVisualId { get; set; }
        public uint RaidSpellVisualMissileSetId { get; set; }
    }
}