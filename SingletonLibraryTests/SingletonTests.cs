using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingletonLibrary;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonLibrary.Tests
{
    [TestClass()]
    public class SingletonTests
    {
        [TestMethod()]
        public void GetInstanceTest()
        {
            Singleton singleton = Singleton.Instace;
            Singleton singleton1 = Singleton.Instace;
            Assert.AreSame(singleton, singleton1);
        }
        [TestMethod()]
        public void GetInstanceThreadTest()
        {
            Singleton singletonA=null;
            Singleton singletonB = null;
            Thread A = new Thread(()=> 
            {
                singletonA = CreateSingleton(22, "Alibek");
            });
            Thread B = new Thread(() =>
            {
                singletonB = CreateSingleton(43, "Shirvani");
            });
            A.Start();
            B.Start();
            A.Join();
            B.Join();
            Assert.AreEqual(singletonA.GetHashCode(), singletonB.GetHashCode());
        }
        public static Singleton CreateSingleton(int age, string name)
        {
            Singleton singleton = Singleton.Instace;
            singleton.Age = age;
            singleton.Name = name;
            return singleton;
        }
    }
}