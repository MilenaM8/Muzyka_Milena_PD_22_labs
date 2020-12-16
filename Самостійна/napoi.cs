namespace samrob
{
    class Napoi
    {
        public string Excerpt { get; }
        public string Country_made { get; }
        public int Cost { get; }
        public int Volume { get; }
        public Napoi(string excerpt, string country_made, int cost, int volume)
        {
            Excerpt = excerpt;
            Country_made = country_made;
            Cost = cost;
            Volume = volume;
        }
    }
}
