namespace CustomLinkedList.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<int> dynamicList;

        [TestInitialize]
        public void TestInitialize()
        {
            this.dynamicList = new DynamicList<int>();
        }

        [TestMethod]
        public void Add_EptyList_ShouldIncrementCount()
        {
            Assert.AreEqual(0, this.dynamicList.Count);
            this.dynamicList.Add(10);
            Assert.AreEqual(1, this.dynamicList.Count, "Count not increment correctly!");

        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAt_EmptyList_ShouldThrow()
        {
            this.dynamicList.RemoveAt(0);
        }

        [TestMethod]
        public void RemoveAt_DynamicListWithElements_ShouldRemoveElementByIndex()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(15);
            this.dynamicList.Add(7);

            Assert.AreEqual(this.dynamicList.RemoveAt(1), 15, "RemoveAt method not remove correctly by index!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveAtWithIndexGreaterThanCount_DynamicListWithElements_ShouldThrow()
        {
            for (int index = 0; index < 50; index++)
            {
                this.dynamicList.Add(index);
            }

            this.dynamicList.RemoveAt(51);
        }

        [TestMethod]
        public void Remove_DynamicListWithElements_ShouldRemoveSpecifiedItem()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(15);
            this.dynamicList.Add(7);

            Assert.AreEqual(this.dynamicList.Remove(7), 2, "Remove method not remove correctly specified item!");
        }

        [TestMethod]
        public void Remove_DynamicListWithElements_ShouldNotFindSpecifiedElement()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(15);
            this.dynamicList.Add(7);

            Assert.AreEqual(this.dynamicList.Remove(77), -1, "Remove method not remove correctly specified item!");
        }

        [TestMethod]
        public void FindIndexOfSpecifiedElement_DynamicListWithElements_ShouldFind()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(15);
            this.dynamicList.Add(7);

            Assert.AreEqual(this.dynamicList.IndexOf(7), 2, "IndexOf method not return correctly the index of specified item!");
        }

        [TestMethod]
        public void CheckWhetherContainsSpecificItem_DynamicListWithElements_ShouldFind()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(15);
            this.dynamicList.Add(7);

            Assert.IsTrue(this.dynamicList.Contains(15), "Contains method not found existing specified item!");
        }

        [TestMethod]
        public void CheckWhetherContainsSpecificItem_DynamicListWithElements_ShouldNotFind()
        {
            this.dynamicList.Add(10);
            this.dynamicList.Add(15);
            this.dynamicList.Add(7);

            Assert.IsFalse(this.dynamicList.Contains(100), "Contains method not found correctly specified item!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestSetIndexator_AccessingInvalidIndex_ShouldThrow()
        {
            for (int index = 0; index < 50; index++)
            {
                this.dynamicList.Add(index);
            }

            this.dynamicList[-1] = 777;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetElementAtInvalidIndex_AccessingInvalidIndex_ShouldThrow()
        {
            for (int index = 0; index < 50; index++)
            {
                this.dynamicList.Add(index);
            }

            var item = this.dynamicList[50];
        }
    }
}
