using System;
using System.Collections.Generic;

namespace MigrateDataPAKN.ModelsPostGre
{
    public partial class User
    {
        public int Id { get; set; }
        public string? Ten { get; set; }
        public string? Matkhau { get; set; }
        public string? Tendaydu { get; set; }
        public string? Email { get; set; }
        public string? Dienthoai { get; set; }
        public string? Tinhtrang { get; set; }
        public string? Quyen { get; set; }
        public int? Maquyen { get; set; }
    }
}
