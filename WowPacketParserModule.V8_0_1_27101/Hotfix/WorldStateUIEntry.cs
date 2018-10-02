using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WorldStateUI)]
    public class WorldStateUIEntry
    {
        public string Icon { get; set; }
        public string String { get; set; }
        public string Tooltip { get; set; }
        public string DynamicTooltip { get; set; }
        public string ExtendedUI { get; set; }
        public int ID { get; set; }
        public ushort MapId { get; set; }
        public ushort AreaId { get; set; }
        public ushort StateVariable { get; set; }
        public byte Type { get; set; }
        public int DynamicIconFileId { get; set; }
        public int DynamicFlashIconFileId { get; set; }
        public byte OrderIndex { get; set; }
        public byte PhaseUseFlags { get; set; }
        public ushort PhaseId { get; set; }
        public ushort PhaseGroupId { get; set; }
        [HotfixArray(3)]
        public ushort[] ExtendedUIStateVariable { get; set; }
    }
}