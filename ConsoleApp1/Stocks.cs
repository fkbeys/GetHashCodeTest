namespace ConsoleApp1
{
    public class StockAsClass
    {
        public int id { get; private set; }

        public StockAsClass(int id)
        {
            this.id = id;
        }
    }
    public record StockAsRecord
    {
        public StockAsRecord(int id)
        {
            this.id = id;
        }

        public int id { get; private set; }
    }
}
