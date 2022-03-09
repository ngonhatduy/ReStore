namespace ReStore.Models
{
    public class BasketModel
    {
        public int Id { get; set; }
        public string BuyerId { get; set; }
        public List<BasketItemModel> Items {get; set;}
    }
}
