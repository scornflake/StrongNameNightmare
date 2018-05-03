using System;
using System.Reflection;
using Xunit;

namespace Tests
{
    public class Class1
    {
        [Fact]
        public void CanWeLoadTheThing()
        {
            Assembly foo = Assembly.Load("Npgsql.EntityFrameworkCore.PostgreSQL, Version=2.0.2.0, Culture=neutral, PublicKeyToken=5d8b90d52f46fda7");
            Console.WriteLine("Got " + foo);
        }
    }
}
