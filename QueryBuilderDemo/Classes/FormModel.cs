using QueryBuilderDemo.Classes;

namespace QueryBuilderDemo
{
    public class FormModel : QueryBuilderBase
    {
        public string Id { get; set; } = string.Empty;
        public string Field { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Input { get; set; } = string.Empty;
        public string Operator { get; set; } = string.Empty;
        public dynamic Value { get; set; } = string.Empty;
    }
}
