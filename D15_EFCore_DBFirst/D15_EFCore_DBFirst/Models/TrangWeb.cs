using System;
using System.Collections.Generic;

namespace D15_EFCore_DBFirst.Models
{
    public partial class TrangWeb
    {
        public TrangWeb()
        {
            PhanQuyen = new HashSet<PhanQuyen>();
        }

        public int MaTrang { get; set; }
        public string TenTrang { get; set; }
        public string Url { get; set; }

        public ICollection<PhanQuyen> PhanQuyen { get; set; }
    }
}
