using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : DbContext
    {
        private const string connection = "Data Source=DURANES;Initial Catalog=Pottencia;Persist Security Info=True;User ID=sa;Password=Lehrer;MultipleActiveResultSets=True";

        public SqlConnection GetConnection()
        {
            {  
                return new SqlConnection(connection);
            }
        }        
    }
}
