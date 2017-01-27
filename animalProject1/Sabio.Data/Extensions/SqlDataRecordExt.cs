using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabio.Data
{
    public static class SqlDataRecordExt
    {
        public static void SetNullableInt32(this SqlDataRecord rec, int index, Int32? value)
        {
            if (value.HasValue)
                rec.SetInt32(index, value.GetValueOrDefault());
            else
                rec.SetDBNull(index);
        }

        public static void SetNullableDouble(this SqlDataRecord rec, int index, double? value)
        {
            if (value.HasValue)
                rec.SetDouble(index, value.GetValueOrDefault());
            else
                rec.SetDBNull(index);
        }

    }
}