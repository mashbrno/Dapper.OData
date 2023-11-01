using Dapper.OData.Infrastructure;
using Microsoft.AspNetCore.OData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;

namespace Dapper.OData;

public static class Setup
{
    public static void AddDapperODataBase(IMvcBuilder builder, IEdmModel edmModel, string conString, int connectionTimeout = 5, bool matchNamesWithUnderscores = false)
    {
        builder.AddOData(opt => opt
            .Filter()
            .Select()
            .Count()
            .OrderBy()
            .Expand()
            .SetMaxTop(null)
            .AddRouteComponents("odata", edmModel));
        builder.Services.AddSingleton<IDbConfiguration>(x => new DbConfiguration(conString, connectionTimeout));
        builder.Services.AddSingleton<ITryCatch, TryCatch>();
        
        DefaultTypeMap.MatchNamesWithUnderscores = matchNamesWithUnderscores;
    }

}