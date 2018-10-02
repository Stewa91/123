using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.WeaponTrailModelDef, HasIndexInData = false)]
    public class WeaponTrailModelDefEntry
    {
        public int LowDefFileDataId { get; set; }
        public ushort WeaponTrailId { get; set; }
        public ushort AnimEnumId { get; set; }
    }
}