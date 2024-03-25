using FluentMigrator;
using System.Data.SqlServerCe;

namespace MySerene3.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20241104_1509)]
public class DefaultDB_20241104_1509_GenreData : AutoReversingMigration
{
    public override void Up()
    {
        Insert.IntoTable("Genre")
            .Row(new { Name = "Action" })
            .Row(new { Name = "Drama" })
            .Row(new { Name = "Comedy" })
            .Row(new { Name = "Sci-fi" })
            .Row(new { Name = "Fantasy" })
            .Row(new { Name = "Documentary" });
    }
}