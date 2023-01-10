namespace Application.Entities
{
    public class ExpenseEntityBase
    {
        public string ItemId { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }   
        public DateTime UpdatedDate { get; set; }
    }
}
