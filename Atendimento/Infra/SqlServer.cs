using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Atendimento.Infra
{
    public class SqlServer : IDB
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection(@"Server=DESKTOP-3894JOI\SQLEXPRESS;Database=Atendimento;User Id=sa;Password=123;");
        }
    }
}
