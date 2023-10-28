using System.CodeDom.Compiler;
using System.CodeDom;

namespace CodeDOMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var compileUnit = new CodeCompileUnit();
            var theNamespace = new CodeNamespace("KoenigRootNamesapce");
            compileUnit.Namespaces.Add(theNamespace);

            var personClass = new CodeTypeDeclaration("Person");
           // personClass.IsInterface = false;//optional
            theNamespace.Types.Add(personClass);

            var walkMethod = new CodeMemberMethod();
            walkMethod.Name = "Walk";
            walkMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            personClass.Members.Add(walkMethod);

            var provider = CodeDomProvider.CreateProvider("VisualBasic");//VisualBasic
            provider.GenerateCodeFromCompileUnit(compileUnit, Console.Out, new CodeGeneratorOptions { BracingStyle = "C" });
        }
    }
}