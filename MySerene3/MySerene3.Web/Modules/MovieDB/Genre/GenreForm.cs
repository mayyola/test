using Serenity.ComponentModel;

namespace MySerene3.MovieDB.Forms;

[FormScript("MovieDB.Genre")]
[BasedOnRow(typeof(GenreRow), CheckNames = true)]
public class GenreForm
{
    public string Name { get; set; }
}