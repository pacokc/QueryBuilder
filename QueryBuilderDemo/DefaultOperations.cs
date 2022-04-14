using System.Collections.ObjectModel;

namespace QueryBuilderDemo
{
    public static class DefaultOperations
    {
        public static Dictionary<string, int> String = new()
        {
            { "equal", 1 },
            { "not equal", 1 },
            { "in", 1 },
            { "not in", 1 },
            { "begins with", 1 },
            { "doesn't begin with", 1 },
            { "contains", 1 },
            { "doesn't contain", 1 },
            { "ends with", 1 },
            { "doesn't end with", 1 },
            { "is empty", 0 },
            { "is not empty", 0 },
            { "is null", 0 },
            { "is not null", 0 }
        };

        public static Dictionary<string, int> Int = new() 
        { 
           { "equal", 1 }, 
           { "not equal", 1 }, 
           { "in", 1 }, 
           { "not in", 1 }, 
           { "less", 1 }, 
           { "less or equal", 1 }, 
           { "greater", 1 }, 
           { "greater or equal", 1 }, 
           { "between", 2 }, 
           { "not between", 2 }, 
           { "is null", 0 }, 
           { "is not null", 0 }
        };

        public static Dictionary<string, int> Float { get { return Int; } }

        public static Dictionary<string, int> DateTime { get { return Int; } }

        public static Dictionary<string, Dictionary<string, int>> Operations = new() { { "string", String }, { "int", Int }, { "datetime", DateTime }, { "float", Float } };
    }
}
