namespace gameServices.Models
{
    public class MyGameById : MyGame
    {
        public int idGame { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public string background_image { get; set; }
        public string description { get; set; }
        public List<string> genres { get; set; }
        public string release_date { get; set; }
        public double note { get; set; }   

        public MyGameById()
        {
        }

        public MyGameById(Game apigame) : base()
        {
            idGame = apigame.id;    
            slug = apigame.slug;
            name = apigame.name;
            background_image = apigame.background_image;
            description = apigame.description;
            genres = new List<string>();
            release_date = apigame.released;
            note = apigame.rating;

            if (apigame.genres != null && apigame.genres.Count() > 0)
            {
                foreach (var item in apigame.genres)
                {
                    genres.Add(item.name);
                }
            }

        }   
    }
}
