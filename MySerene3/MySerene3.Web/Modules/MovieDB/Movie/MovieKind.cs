using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace MySerene3.MovieDB;

[EnumKey("MovieDB.MovieKind")]
public enum MovieKind
{
    [Description("Film")]
    Film = 1,
    [Description("TV Series")]
    TvSeries = 2,
    [Description("Mini Series")]
    MiniSeries = 3
}