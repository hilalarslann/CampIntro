using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AbstractClass
{
    /*Bu classı kullanıyor olmamızdaki amaç ortak olan kodları buraya koymak 
      yani tek amacı diğer classlara hizmet etmek.Kullanım amacını belirtmemiz gerekiyor.
      Tam bu noktada abstract kullanırız.*/
    public abstract class BaseDb
    {
        public abstract string GetDbVersion();

        public DataTable ExecuteSql(string sql)
        {
            return new DataTable();
        }
    }

    public class SqlServerDb: BaseDb
    {
        public override string GetDbVersion() => "SqlServer 2012;";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WITH(NOLOCK) WHERE ID = {id}";
        }
    }

    public class OracleDb: BaseDb
    {
        public override string GetDbVersion() => "Orcale 18c;";

        public string GenerateSql(int id)
        {
            return $"SELECT * FROM USERS WHERE USER_ID = {id}";
        }
    }
}
