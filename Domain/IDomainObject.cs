using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface IDomainObject
    {
        int IDValue { get; }
        string TableName { get; }
        string InsertValues { get; }
        string Join { get; }
        string UpdateValues { get; }
        string Condition { get; }
        string OrderBy { get; }
        string ConditionGetList { get; }
        string ConditionGetObject { get; }

        IDomainObject ReadObjectRow(SqlDataReader reader);
    }
}
