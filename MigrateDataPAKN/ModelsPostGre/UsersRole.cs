using System;
using System.Collections.Generic;

namespace MigrateDataPAKN.ModelsPostGre
{
    public partial class UsersRole
    {
        public int Id { get; set; }
        public int? Maquyen { get; set; }
        public string? Tenquyen { get; set; }
    }
}
