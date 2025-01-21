namespace AnimeAsp.Models
{
    public class VideoModel
    {
        public long Id { get; set; }
        public string VideoUrl { get; set; }
        public string Filesize { get; set; }
        public string Format { get; set; }
        public string Resolution { get; set; }
        
        // Link to multiple episodes if necessary
        public IEnumerable<EpisodeModel> Episodes { get; set; }

        public VideoModel()
        {
            Episodes = new List<EpisodeModel>(); // Initialize to an empty list
        }

        public VideoModel(long id, string videoUrl, string filesize, string format, string resolution, IEnumerable<EpisodeModel> episodes)
        {
            Id = id;
            VideoUrl = videoUrl;
            Filesize = filesize;
            Format = format;
            Resolution = resolution;
            Episodes = episodes;
        }
    }
}