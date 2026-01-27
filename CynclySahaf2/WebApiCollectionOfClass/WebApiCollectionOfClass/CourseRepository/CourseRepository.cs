namespace WebApiCollectionOfClass.CourseRepository;

public class CoursesRepository
{

    public List<string> GetCourses()
    {
        return new List<string>
        {

            "Entity Framework",
            "Entity Framework Core",
            "Dapper",
            "NHibernate",
            "LINQ to SQL",
            "ADO.NET",
            "Micro ORM",
            "PetaPoco",
            "ServiceStack.OrmLite",
            "RepoDb",

            "EF Core InMemory",
            "EF Core SQLite",
            "EF Core SQL Server",
            "EF Core Migrations",
            "EF Core Fluent API",
            "EF Core Change Tracking",
            "EF Core Lazy Loading",
            "EF Core Value Converters",
            "EF Core Compiled Queries",
            "EF Core Interceptors",

            "AutoMapper",
            "FluentValidation",
            "MediatR",
            "Polly",
            "Serilog",
            "NLog",
            "log4net",
            "Hangfire",
            "Quartz.NET",
            "MassTransit",

            "MongoDB.Driver",
            "Cosmos DB SDK",
            "StackExchange.Redis",
            "ElasticSearch.NET",
            "RavenDB Client"
        };
    }
}
