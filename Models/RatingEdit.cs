namespace RestaurantRaterAPI.Models
{
    public class RatingEdit
    {
        public int Id { get; set; }
        public float Score { get; set; }
        public int RestaurantId { get; set; }
    }
}