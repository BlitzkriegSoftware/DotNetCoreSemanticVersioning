using System;

namespace semver_example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get Assembly Object, casting it to this class type
            var assembly = typeof(Program).Assembly;
            // Get all custom attribute data
            foreach (var attribute in assembly.GetCustomAttributesData())
            {
                // try to find a value
                if (!attribute.TryParse(out string value)) value = string.Empty;
                // write name and value
                Console.WriteLine($"{attribute.AttributeType.Name} - {value}");
            }
        }

    }
}
