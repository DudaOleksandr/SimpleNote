using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_2
{
    class Table : DataTable
    {
        public static Table GetTable()
        {
            Table table = new Table();
            return table;
        }
    }
}
