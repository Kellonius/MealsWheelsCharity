using System;
using System.Data.SqlClient;

namespace Cape_Senior_Center_Inventory_System.DemoStuff
{
    public static class SqlParameterCollectionExtensions
    {
        public static SqlParameter AddWithValue(this SqlParameterCollection target, string parameterName, object value,
            object nullvalue)
        {
            if (value == null)
            {
                return target.AddWithValue(parameterName, nullvalue ?? DBNull.Value);
            }

            return target.AddWithValue(parameterName, value);
        }
    }
}
