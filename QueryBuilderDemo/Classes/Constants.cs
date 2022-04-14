namespace QueryBuilderDemo.Classes
{
    public static class Constants
    {
        public static Dictionary<string, string> InputType = new() { { "string", "text" }, { "int", "number" }, { "datetime", "datetime" }, { "boolean", "checkbox" }, { "float", "number" } };
        public static Dictionary<string, object> TypeDefaultValue = new() { { "string", "" }, { "int", 0 }, { "datetime", DateTime.Now }, { "boolean", false }, { "float", 0f } };
    }
}
