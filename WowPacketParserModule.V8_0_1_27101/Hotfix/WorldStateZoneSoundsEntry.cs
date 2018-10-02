using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WorldStateZoneSounds, HasIndexInData = false)]
    public class WorldStateZoneSoundsEntry
    {
        public ushort WorldStateId { get; set; }
        public ushort WorldStateValue { get; set; }
        public ushort AreaId { get; set; }
        public int WmoAreaId { get; set; }
        public ushort ZoneIntroMusicId { get; set; }
        public ushort ZoneMusicId { get; set; }
        public ushort SoundAmbienceId { get; set; }
        public byte SoundProviderPreferencesId { get; set; }
    }
}