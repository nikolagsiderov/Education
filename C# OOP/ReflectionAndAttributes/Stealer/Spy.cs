using System;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string classNameToInvestigate, params string[] fieldNamesToInvestigate)
        {
            var info = new StringBuilder();

            info.AppendLine($"Class under investigation: {classNameToInvestigate}");

            foreach (var fieldName in fieldNamesToInvestigate)
            {
                var bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static;
                var classType = Type.GetType(classNameToInvestigate);
                var field = classType.GetField(fieldName, bindFlags);
                var classInstance = Activator.CreateInstance(classType);
                var fieldValue = field.GetValue(classInstance);

                info.AppendLine($"{fieldName} {fieldValue}");
            }

            return info.ToString();
        }
    }
}
