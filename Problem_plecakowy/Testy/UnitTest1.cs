using Problem_plecakowy;
namespace Testy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodCountElements()
        {
            int s = 1;
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
             foreach (int n in sizes)
                 {
                 Problem problem = new Problem(n,s);
                 Assert.AreEqual(n, problem.items.Count);
                 }
        }

        [TestMethod]
        public void TestMethodMinOneGoodElements()
        {
            int n = 5;
            int s = 1;
            int c = 15;
            Item item1 = new Item(10,8,1);
            Item item2 = new Item(8,13,2);
            Item item3 = new Item(4, 1, 3);
            Item item4 = new Item(7, 2, 4);
            Item item5 = new Item(6, 7, 5);
            List<Item> items = new List<Item>() {item1, item2,item3,item4,item5};
            Problem problem = new Problem(n,s,items);
            problem.Sorting();
            Result result = problem.Solve(c);

            Assert.IsTrue(result.result.Count>0);
            
        }

        [TestMethod]
        public void TestMethodNoGoodElements()
        {
            int n = 5;
            int s = 1;
            int c = 3;
            Item item1 = new Item(10, 8, 1);
            Item item2 = new Item(8, 13, 2);
            Item item3 = new Item(4, 1, 3);
            Item item4 = new Item(7, 2, 4);
            Item item5 = new Item(6, 7, 5);
            List<Item> items = new List<Item>() { item1, item2, item3, item4, item5 };
            Problem problem = new Problem(n, s, items);
            problem.Sorting();
            Result result = problem.Solve(c);

            Assert.IsTrue(result.result.Count == 0);

        }

        [TestMethod]
        public void TestMethodSequencesElements()
        {
            int n = 5;
            int s = 1;
            int c = 15;
            Item item1 = new Item(2, 5, 1);
            Item item2 = new Item(8, 7, 2);
            Item item3 = new Item(5, 4, 3);
            Item item4 = new Item(10, 2, 4);
            Item item5 = new Item(7, 1, 5);
            List<Item> items = new List<Item>() { item1, item2, item3, item4, item5 };
            Problem problem = new Problem(n, s, items);
            problem.Sorting();
            Result result = problem.Solve(c);

         
            List<Item> items2 = new List<Item>() { item3, item1, item5, item4, item2 };
            Problem problem2 = new Problem(n, s, items2);
            problem2.Sorting();
            Result result2 = problem2.Solve(c);

            Assert.IsTrue((result.result).SequenceEqual(result2.result));

        }

        [TestMethod]
        public void TestMethodSumationValueGoodElements()
        {
            int n = 10;
            int s = 1;
            int c = 25;
            Item item1 = new Item(2, 5, 1);
            Item item2 = new Item(8, 7, 2);
            Item item3 = new Item(5, 4, 3);
            Item item4 = new Item(10, 2, 4);
            Item item5 = new Item(7, 9, 5);
            Item item6 = new Item(6, 1, 6);
            Item item7 = new Item(10, 3, 7);
            Item item8 = new Item(3, 7, 8);
            Item item9 = new Item(7, 5, 9);
            Item item10 = new Item(10, 3, 10);
            List<Item> items = new List<Item>() { item1, item2, item3, item4, item5, item6, item7, item8, item9, item10 };
            Problem problem = new Problem(n, s, items);
            problem.Sorting();
            Result result = problem.Solve(c);

            Assert.IsTrue(result.total_weight==25 && result.total_value==32);

        }

        [TestMethod]
        public void TestMethodOtherResultOfCreateElement()
        {
            int n = 10;
            int s1 = 1;
            int s2 = 3;
            int c = 25;
            Problem problem1 = new Problem(n, s1);
            Problem problem2 = new Problem(n, s2);
            

            Assert.IsFalse((problem1.items).SequenceEqual(problem2.items));

        }

        [TestMethod]
        public void TestMethodZeroCapacityOfBackpack()
        {
            int n = 10;
            int s = 1;
            int c = 0;
            Problem problem = new Problem(n, s);
            problem.Sorting();
            Result result = problem.Solve(c);
            


            Assert.IsTrue(!(result.result).Any() && (result.total_value)==0 && (result.total_weight)==0);

        }

        [TestMethod]
        public void TestMethodZeroElements()
        {
            int n = 0;
            int s = 1;
            int c = 25;
            Problem problem = new Problem(n, s);
            problem.Sorting();
            Result result = problem.Solve(c);



            Assert.IsTrue(!(result.result).Any() && (result.total_value) == 0 && (result.total_weight) == 0);

        }
        /*public void TestMethodSumationNumbersOfElements()
        {
            int n;            
            Problem problem = new Problem(n, s);
            problem.Sorting();
            Result result = problem.Solve(c);

            Assert.IsTrue(result.total_weight == 25 && result.total_value == 32);
        
        }*/
    }
}