using FluentMigrator;
using System.Data.SqlServerCe;

namespace MySerene3.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20241104_1507)]
public class DefaultDB_20241104_1507_MovieKind : AutoReversingMigration
{
    public override void Up()
    {

        Alter.Table("Movie")
            .AddColumn("Kind").AsInt32().NotNullable().WithDefaultValue(1);
    }
}