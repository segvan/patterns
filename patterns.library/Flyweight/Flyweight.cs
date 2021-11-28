using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.dotMemoryUnit;
using JetBrains.dotMemoryUnit.Kernel;
using NUnit.Framework;

namespace patterns.library.Flyweight
{
    public class User
    {
        private string fullName;

        public User(string fullName)
        {
            this.fullName = fullName;
        }
    }

    public class User2
    {
        private static List<string> strings = new List<string>();
        private int firstName;
        private int lastName;

        public User2(string firstName, string lastName)
        {
            this.firstName = GetOrAdd(firstName);
            this.lastName = GetOrAdd(lastName);
        }

        private int GetOrAdd(string s)
        {
            var i = strings.IndexOf(s);
            if (i != -1)
            {
                return i;
            }
            
            strings.Add(s);
            return strings.Count - 1;
        }
    }

    [TestFixture]
    public class FlyweightTest
    {
        [Test]
        public void TestUser() // 8375Kb
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString()).ToList();
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString()).ToList();
            var listOfUsers = new List<User>();
            foreach (var firstName in firstNames)
                foreach (var lastName in lastNames)
                    listOfUsers.Add(new User($"{firstName} {lastName}"));
            ForceGarbaceCollect();
            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes / 1000);
            });
        }
        
        [Test]
        public void TestUser2() // 7754Kb
        {
            var firstNames = Enumerable.Range(0, 100).Select(_ => RandomString()).ToList();
            var lastNames = Enumerable.Range(0, 100).Select(_ => RandomString()).ToList();
            var listOfUsers = new List<User2>();
            foreach (var firstName in firstNames)
            foreach (var lastName in lastNames)
                listOfUsers.Add(new User2(firstName, lastName));
            ForceGarbaceCollect();
            dotMemory.Check(memory =>
            {
                Console.WriteLine(memory.SizeInBytes / 1000);
            });
        }

        private static void ForceGarbaceCollect()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }

        private string RandomString()
        {
            Random r = new Random();
            return new string(
                Enumerable.Range(0, 10)
                    .Select(_ => (char) ('a' + r.Next(26)))
                    .ToArray());
        }
    }
}