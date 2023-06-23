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

    public string AnalyzeAccessModifiers(string className)
    {
        Type classType = Type.GetType(className);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance|BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance|BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        foreach(FieldInfo field in classFields)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }
        foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }
        foreach(MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string className)
    {
        StringBuilder sb = new StringBuilder();

        Type classType = Type.GetType(className);

        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        sb.AppendLine($"All private Methods of Class: {className}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in classNonPublicMethods)
        {
            sb.AppendLine(method.Name);
        }

        return sb.ToString().Trim();
    }
}
