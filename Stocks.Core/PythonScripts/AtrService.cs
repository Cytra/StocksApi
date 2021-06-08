using System;
using System.Collections.Generic;
using System.IO;
using IronPython.Hosting;

namespace Stocks.Core.PythonScripts
{
    public interface IAtrService
    {
        void GetAtr();
    }
    public class AtrService : IAtrService
    {
        public void GetAtr()
        {
            var engine = Python.CreateEngine();
            ICollection<string> searchPaths = engine.GetSearchPaths();
            searchPaths.Add("C:\\Users\\User\\AppData\\Local\\Programs\\Python\\Python39\\Lib");
            searchPaths.Add("C:\\Users\\User\\AppData\\Local\\Programs\\Python\\Python39\\Lib\\site-packages");
            engine.SetSearchPaths(searchPaths);
            //reading code from file
            var source = engine.CreateScriptSourceFromFile(Path.Combine("C:\\Users\\User\\Desktop\\StocksApi\\Stocks.Core\\PythonScripts", "ATR2.py"));
            var scope = engine.CreateScope();
            //executing script in scope
            source.Execute(scope);
            var classCalculator = scope.GetVariable("ATR");
            //initializing class
            var calculatorInstance = engine.Operations.CreateInstance(classCalculator);
            var test = calculatorInstance.GetUrl("bam");
            Console.WriteLine("{0}", test);
        }
    }
}
