using System.Reflection;
using Realm.Tests.Tests;
using NUnitLite;

namespace Realm.Tests.Console
{
    internal class Program
    {
        public static int Main(string[] args)
        {
            return new AutoRun(typeof(RealmTests).GetTypeInfo().Assembly).Execute(args);
        }
    }
}