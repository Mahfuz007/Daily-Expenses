namespace Application.Entities
{
    public class Category: ExpenseEntityBase
    {
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsExpense { get; set; } = false;
    }
}
