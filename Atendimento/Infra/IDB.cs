using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Atendimento.Infra
{
    public interface IDB
    {
        SqlConnection GetConnection();
    }
}
