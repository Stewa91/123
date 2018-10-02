using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.MapCelestialBody, HasIndexInData = false)]
    public class MapCelestialBodyEntry
    {
        public ushort CelestialBodyId { get; set; }
        public uint PlayerConditionId { get; set; }
        public short MapId { get; set; }
    }
}