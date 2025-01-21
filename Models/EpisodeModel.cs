namespace AnimeAsp.Models
{
    public class EpisodeModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public int EpisodeNumber { get; set; }
        public DateTime StartDate { get; set; }
        public long MovieId { get; set; }
        public MovieModel Movie { get; set; }
        public ICollection<VideoModel> Videos { get; set; }

        public EpisodeModel()
        {
            Videos = new List<VideoModel>();  // Initialize the collection of videos
        }

        public EpisodeModel(string title, int episodeNumber, DateTime startDate, long movieId, MovieModel movie, ICollection<VideoModel> videos)
        {
            Title = title;
            EpisodeNumber = episodeNumber;
            StartDate = startDate;
            MovieId = movieId;
            Movie = movie;
            Videos = videos;
        }
    }
}