using System;
using JOS.MyNugetPackage.Client2;

namespace Client2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var companyQuery = new GetCompanyNameQuery();
            var result = companyQuery.Execute();
            Console.WriteLine(result);
        }
    }
}
