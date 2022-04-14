namespace QueryBuilderDemo.Classes
{
    public class HeadModel : QueryBuilderBase
    {
        public string Condition { get; set; } = string.Empty;
        public List<QueryBuilderBase> FormModel { get; set; } = default!;
    }
}
