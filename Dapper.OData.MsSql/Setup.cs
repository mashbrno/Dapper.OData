using Dapper.OData.Infrastructure;
using Microsoft.AspNetCore.OData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;

namespace Dapper.OData.MsSql;

public static class Setup
{
    public static void AddDapperOData(this IMvcBuilder builder, IEdmModel edmModel, string conString, int connectionTimeout = 5, bool matchNamesWithUnderscores = false)
    {
        Dapper.OData.Setup.AddDapperODataBase(builder, edmModel, conString, connectionTimeout, matchNamesWithUnderscores);
        builder.Services.AddTransient<IDbConnection, DbConnection>();
    }
}