namespace ConsoleApp1.Models
{
    public record StockAsRecord
    {
        public StockAsRecord(int id)
        {
            this.id = id;
        }

        public int id { get; private set; }
    }
}
