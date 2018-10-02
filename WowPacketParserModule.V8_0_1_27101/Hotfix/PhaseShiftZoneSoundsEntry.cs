using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.PhaseShiftZoneSounds, HasIndexInData = false)]
    public class PhaseShiftZoneSoundsEntry
    {
        public ushort AreaId { get; set; }
        public byte WmoAreaId { get; set; }
        public ushort PhaseId { get; set; }
        public ushort PhaseGroupId { get; set; }
        public byte PhaseUseFlags { get; set; }
        public int ZoneIntroMusicId { get; set; }
        public int ZoneMusicId { get; set; }
        public ushort SoundAmbienceId { get; set; }
        public byte SoundProviderPreferencesId { get; set; }
        public uint UwZoneIntroMusicId { get; set; }
        public uint UwZoneMusicId { get; set; }
        public ushort UwSoundAmbienceId { get; set; }
        public byte UwSoundProviderPreferencesId { get; set; }
    }
}