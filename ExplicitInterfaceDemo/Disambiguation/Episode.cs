using System.Runtime.InteropServices;

namespace JoanVilarino.Demos.ExplicitInterfaceDemo.Disambiguation
{
    public class Episode : IMovie, ISerie
    {
        private string _title;
        private int _season;
        private int _episode;
        private string _episodeTitle;

        public Episode(string title, int season, int episode, string episodeTitle)
        {
            _title = title;
            _season = season;
            _episode = episode;
            _episodeTitle = episodeTitle;
        }

        // Implement IMovie
        string IMovie.GetTitle()
        {
            return _title;
        }

        // Implement ISerie
        string ISerie.GetTitle()
        {
            return string.Format("{0} - (S{1:00}/E{2:00}) {3}", _title, _season, _episode, _episodeTitle);
        }

    }
}
