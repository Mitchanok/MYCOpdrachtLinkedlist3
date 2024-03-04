using MYC3Opdracht3;
using System.Collections.Generic;
using System.Globalization;
using FluentAssertions;

namespace Test
{
    public class Tests
    {
 

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void When_I_Use_WHere_It_Will_Give_Under_Four()
        {
            var mylist = new MyLInkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);

            var numbers = mylist.Where(n => n < 3);

            Assert.IsNotEmpty(numbers);
        }

        [Test]
        public void When_I_Use_WHere_It_Will_Give_Above_Three()
        {

            var mylist = new MyLInkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);

            var numbers = mylist.Where(n => n > 4);

            Assert.IsNotEmpty(numbers);
        }


        [Test]
        public void That_Select_Will_Give_String_To_Numbers_Above_Two()
        {
            var mylist = new MyLInkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);

            var numbers = mylist.Where(n => n > 2).Select(n => $"string:{n}");

         
            
            Assert.IsNotEmpty(numbers);
        }
        [Test]
        public void That_Select_Will_Give_String_To_Numbers_Under_Four()
        {
            var mylist = new MyLInkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(6);

            var numbers = mylist.Where(n => n < 4).Select(n => $"string:{n}");



            Assert.IsNotEmpty(numbers);
        }
        [Test]
        public void Test_Count()
        {
            var mylist = new MyLInkedList<int>();

       
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }

           
            Assert.AreEqual(3, numbers.Count);
        }
        [Test]

        public void Test_Any_return_True()
        {
            var mylist = new MyLInkedList<int>();

            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }
            bool result =  numbers.Any();
            Assert.IsTrue(result);
        }
        [Test]

        public void Test_Any_return_False()
        {
            var mylist = new MyLInkedList<int>();

            List<int> numbers = new List<int>();
            foreach (var item in mylist)
            {
                numbers.Add(item);
            }
            bool result = numbers.Any();
            Assert.IsFalse(result);

        }

        [Test]

        public void Test_That_Return_Will_Be_First_Element()
        {
            var mylist = new MyLInkedList<int>();
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);

            var result = mylist.FirstOrDefault();
            Assert.AreEqual(1, result);
        }

        [Test]

        public void Test_Empty_ReturnDefault()
        {
            var mylist = new MyLInkedList<int>();

            mylist.Add(1);  
            mylist.Add(2);
            mylist.Clear();

            var result = mylist.FirstOrDefault();
            mylist.Should().BeEmpty();
            Assert.AreEqual(default(int), result);


        }
    }

}