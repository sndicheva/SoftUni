using System.Reflection;
using System.Text;

namespace Stealer;

public class Spy
{

    public string StealFieldInfo(string className, params string[] fields)
    {
        Type classType = Type.GetType(className);

        FieldInfo[] classFields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        StringBuilder sb = new StringBuilder();
        object classInstance = Activator.CreateInstance(classType, new object[] { });
        sb.AppendLine($"Class under investigation: {className}");

        foreach (FieldInfo field in classFields.Where(f => fields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().TrimEnd();
    }
}
