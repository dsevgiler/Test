namespace TestCore8._0.Entity
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int categoryid { get; set; }
        public category category { get; set; }

    }
}
