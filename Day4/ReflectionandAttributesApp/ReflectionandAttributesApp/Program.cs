using AccountConstructorApp.Model;
using System;
using System.Linq;
using System.Reflection;

namespace ReflectionandAttributesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();
            //  CaseStudy1(typeof(string));

            // CaseStudy1(typeof(Account));


            Type accType = typeof(Account);
            MethodInfo[] methods= accType.GetMethods();
            var methodsWithAttribute= methods.Where(m=>m.IsDefined(typeof(NeedUrgentAttentionAttribute), false)).ToList();
            Console.WriteLine(methodsWithAttribute.Count);

        }

        private static void CaseStudy1(Type type)
        {
            Type stringType = type;
            MethodInfo[] methods = stringType.GetMethods();
            Console.WriteLine("found methods :" + methods.Length);

            PropertyInfo[] properties = stringType.GetProperties();
            Console.WriteLine("found porperties :" + properties.Length);
        }
    }
}