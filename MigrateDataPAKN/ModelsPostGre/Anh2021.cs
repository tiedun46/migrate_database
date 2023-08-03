using System;
using System.Collections.Generic;

namespace MigrateDataPAKN.ModelsPostGre
{
    public partial class Anh2021
    {
        public int Id { get; set; }
        public string? Tieudeanh { get; set; }
        public string? Thongtinanh { get; set; }
        public string? Duongdananh { get; set; }
        public string? Noidungbaocao { get; set; }
        public string? Loaianh { get; set; }
        public double? Kinhdo { get; set; }
        public double? Vido { get; set; }
        public string? Machuongtrinh { get; set; }
        public string? Madonvi { get; set; }
        public string? Maduan { get; set; }
        public string? Manoidungthanhphan { get; set; }
        public string? Mathon { get; set; }
        public DateOnly? Ngaythangnam { get; set; }
        public int? Nam { get; set; }
    }
}
