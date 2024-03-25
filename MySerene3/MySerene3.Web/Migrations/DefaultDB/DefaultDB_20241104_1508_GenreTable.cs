using FluentMigrator;
using System.Data.SqlServerCe;

namespace MySerene3.Migrations.DefaultDB;
[DefaultDB, MigrationKey(20241104_1508)]
public class DefaultDB_20241104_1508_GenreTable : AutoReversingMigration
{
    public override void Up()
    {

        Create.Table("Genre")
            .WithColumn("GenreId").AsInt32().NotNullable()
                .PrimaryKey().Identity()
            .WithColumn("Name").AsString(100).NotNullable();

        Alter.Table("Movie")
            .AddColumn("GenreId").AsInt32().Nullable()
                .ForeignKey("FK_Movie_GenreId", "Genre", "GenreId");
    }
}