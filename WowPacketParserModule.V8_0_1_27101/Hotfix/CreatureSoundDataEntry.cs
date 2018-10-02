using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.CreatureSoundData, HasIndexInData = false)]
    public class CreatureSoundDataEntry
    {
        public uint SoundExertionId { get; set; }
        public uint SoundExertionCriticalId { get; set; }
        public uint SoundInjuryId { get; set; }
        public uint SoundInjuryCriticalId { get; set; }
        public uint SoundInjuryCrushingBlowId { get; set; }
        public uint SoundDeathId { get; set; }
        public int SoundStunId { get; set; }
        public uint SoundStandId { get; set; }
        public uint SoundFootstepId { get; set; }
        public uint SoundAggroId { get; set; }
        public uint SoundWingFlapId { get; set; }
        public int SoundWingGlideId { get; set; }
        public uint SoundAlertId { get; set; }
        public int SoundJumpStartId { get; set; }
        public int SoundJumpEndId { get; set; }
        public int SoundPetAttackId { get; set; }
        public int SoundPetOrderId { get; set; }
        public uint SoundPetDismissId { get; set; }
        public int LoopSoundId { get; set; }
        public int BirthSoundId { get; set; }
        public uint SpellCastDirectedSoundId { get; set; }
        public int SubmergeSoundId { get; set; }
        public int SubmergedSoundId { get; set; }
        public int WindupSoundId { get; set; }
        public int WindupCriticalSoundId { get; set; }
        public uint ChargeSoundId { get; set; }
        public int ChargeCriticalSoundId { get; set; }
        public int BattleShoutSoundId { get; set; }
        public int BattleShoutCriticalSoundId { get; set; }
        public uint TauntSoundId { get; set; }
        public int CreatureSoundDataIDPet { get; set; }
        public uint NPCSoundId { get; set; }
        public float FidgetDelaySecondsMin { get; set; }
        public float FidgetDelaySecondsMax { get; set; }
        public byte CreatureImpactType { get; set; }
        [HotfixArray(5)]
        public int[] SoundFidget { get; set; }
        [HotfixArray(4)]
        public int[] CustomAttack { get; set; }
    }
}