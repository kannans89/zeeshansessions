using IronPython.Hosting;

namespace PythonDLRApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scriptPath = @"C:\temp\add.py"; // Path to your Python script

            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var source = engine.CreateScriptSourceFromFile(scriptPath);

            source.Execute(scope);

            if (scope.ContainsVariable("add"))
            {
                dynamic result = scope.GetVariable("add")(5, 3);
                Console.WriteLine("Result of add function: " + result);
            }
            else
            {
                Console.WriteLine("The 'add' function was not found in the Python script.");
            }

            Console.ReadKey();

        }
    }
}