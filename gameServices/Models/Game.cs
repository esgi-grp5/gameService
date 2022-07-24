﻿namespace gameServices.Models
{
    public class Game
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string name_original { get; set; }
        public string description { get; set; }
        public object metacritic { get; set; }
        public List<object> metacritic_platforms { get; set; }
        public string released { get; set; }
        public bool tba { get; set; }
        public DateTime updated { get; set; }
        public string background_image { get; set; }
        public string background_image_additional { get; set; }
        public string website { get; set; }
        public double rating { get; set; }
        public int rating_top { get; set; }
        public List<Rating> ratings { get; set; }
        public int added { get; set; }
        public int playtime { get; set; }
        public int screenshots_count { get; set; }
        public int movies_count { get; set; }
        public int creators_count { get; set; }
        public int achievements_count { get; set; }
        public int parent_achievements_count { get; set; }
        public string reddit_url { get; set; }
        public string reddit_name { get; set; }
        public string reddit_description { get; set; }
        public string reddit_logo { get; set; }
        public int reddit_count { get; set; }
        public int twitch_count { get; set; }
        public int youtube_count { get; set; }
        public int reviews_text_count { get; set; }
        public int ratings_count { get; set; }
        public int suggestions_count { get; set; }
        public List<object> alternative_names { get; set; }
        public string metacritic_url { get; set; }
        public int parents_count { get; set; }
        public int additions_count { get; set; }
        public int game_series_count { get; set; }
        public object user_game { get; set; }
        public int reviews_count { get; set; }
        public string saturated_color { get; set; }
        public string dominant_color { get; set; }
        public List<Developer> developers { get; set; }
        public List<Genre> genres { get; set; }
        public List<Tag> tags { get; set; }
        public List<Publisher> publishers { get; set; }
        public object esrb_rating { get; set; }
        public object clip { get; set; }
        public string description_raw { get; set; }
    }

}
