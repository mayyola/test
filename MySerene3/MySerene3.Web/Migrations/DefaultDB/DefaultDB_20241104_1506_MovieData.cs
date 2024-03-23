using FluentMigrator;
using System.Data.SqlServerCe;

namespace MySerene3.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20241104_1506)]
public class DefaultDB_20241104_1506_MovieKind : AutoReversingMigration
{
    public override void Up()
    {
        
        Insert.IntoTable("Movie") 
            .Row(new
            {
                Title = "The Matrix",
            });
    }
}