namespace AnimeAsp.Models
{
    public class MovieModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }
        public string Image { get; set; }
        public ICollection<CategoryModel> Categories { get; set; }

        public ICollection<EpisodeModel> Episodes { get; set; }

        public MovieModel()
        {
            Categories = new List<CategoryModel>();
            Episodes = new List<EpisodeModel>();
        }

        public MovieModel(string title, string description, DateTime releaseDate, string duration,
            string image)
        {
            Title = title;
            Description = description;
            ReleaseDate = releaseDate;
            Duration = duration;
            Image = image;
            Categories = new List<CategoryModel>();
            Episodes = new List<EpisodeModel>();
        }
    }
}