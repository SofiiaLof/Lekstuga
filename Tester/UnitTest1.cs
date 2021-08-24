using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace Tester
{
    public class UnitTest1 //namnet på testgruppen
    {
        [Fact] //visar att det är ett test
        public void Test1() //Namnet på testet
        {
            Assert.Equal(4, 4);
            Assert.NotEqual(4, 5);
            Assert.True(true);
            Assert.False(true);

        }

        [Fact]
        public void TestaVariabler()
        {
            string name;
            bool level = false;
            if (level)
            {
                name = "Mr.Smith";
            }
            else
            {
                name = "Sofiia";
            }
            Assert.Equal("Sofiia",name);
        }

        [Fact]
        public void Test2() { 

                 Assert. Equal(5, 2);
             }

        [Fact]
        public void Test3()
        {
            Assert.True("Jag har fyllt " + 29 == "Jag har fyllt 29");
        }

        [Fact]
        public void Test4()
        {
            int bigNumber = 2147483647;
            int biggerNumber = bigNumber + 1;
            Assert.True(biggerNumber > bigNumber);

            string purchasedDrink;
            int age = 28;

            if (age > 18)
            {
                purchasedDrink = "Beer";
            }
            else
            {
                purchasedDrink = "Coca-Cola";
            }
        }
        


        
    }
}
