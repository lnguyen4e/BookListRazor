using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace BulkBook.DataAccess.Repository.IRepository
{
    public interface ISP_Call:IDisposable
    {
        T Sing<T>(string prodcedureName, DynamicParameters param = null);
        void Execute(string prodcedureName, DynamicParameters param = null);
        T OneRecord<T>(string prodcedureName, DynamicParameters param = null);
        IEnumerable<T> List<T>(string prodcedureName, DynamicParameters param = null);
        Tuple<IEnumerable<T1>,IEnumerable<T2>> List<T1,T2>(string prodcedureName, DynamicParameters param = null);
    }
}
