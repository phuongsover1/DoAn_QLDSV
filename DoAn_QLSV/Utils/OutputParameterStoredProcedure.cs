using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_QLSV.Utils
{
    public class OutputParameterStoredProcedure
    {
        public string Name { get; set; }
        public SqlDbType Type { get; set; }
        public int Length { get; set; }
    }
}
