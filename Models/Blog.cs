namespace purplebuzzzzzzzz.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //public Blog(int id, string title, string description, string imageUrl)
        //{
        //    Id = id;
        //    Title = title;
        //    Description = description;
        //    Image = imageUrl;
        //    CreatedAt = DateTime.Now;
        //}
    }
}
