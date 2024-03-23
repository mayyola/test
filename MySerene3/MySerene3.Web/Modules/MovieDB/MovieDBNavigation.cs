using Serenity.Navigation;
using MyPages = MySerene3.MovieDB.Pages;
[assembly: NavigationMenu(6000, "MovieDB", icon: "fa-film")]
[assembly: NavigationLink(6100, "MovieDB/Movies", typeof(MyPages.MoviePage), icon: "fa-video-camera")]