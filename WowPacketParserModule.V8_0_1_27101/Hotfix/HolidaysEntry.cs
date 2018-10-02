using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V8_0_1_27101.Hotfix
{
    [HotfixStructure(DB2Hash.Holidays)]
    public class HolidaysEntry
    {
        public int ID { get; set; }
        public ushort Region { get; set; }
        public byte Looping { get; set; }
        public uint HolidayNameId { get; set; }
        public uint HolidayDescriptionId { get; set; }
        public byte Priority { get; set; }
        public byte CalendarFilterType { get; set; }
        public byte Flags { get; set; }
        [HotfixArray(10)]
        public ushort[] Duration { get; set; }
        [HotfixArray(16)]
        public int[] Date { get; set; }
        [HotfixArray(10)]
        public byte[] CalendarFlags { get; set; }
        [HotfixArray(3)]
        public int[] TextureFileDataId { get; set; }
    }
}