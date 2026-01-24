using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities (Low, Medium, High)
    // Expected Result:  High, Medium, Low
    // Defect(s) Found: 1. The loop condition 'index < _queue.Count - 1' caused the last items to be ignored.
    //2. The Dequeue method did not remove the item from the queue after finding it.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        //1. Should return high
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("High", item, "Expected High item first");

        //2. Should return medium
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Medium", item, "Expected Medium item second");

        //3. Should return low
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Low", item, "Expected low priority item last.");
    }

    [TestMethod]
    // Scenario: Add multiple same priority items (5,5,5)
    // Expected Result: The items should follow FIFO logic by coming out in the same order that they were added
    // Defect(s) Found: The comparison '>=' allowed items that came in later that have the same priority to be chosen first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 10);
        priorityQueue.Enqueue("Second", 10);
        priorityQueue.Enqueue("Third", 10);

        //1. Should return "First" 
        var item = priorityQueue.Dequeue();
        Assert.AreEqual("First", item, "Expected first item first");

        //2. Should return "Second"
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Second", item, "Expected Second Item second.");

        //3. Should return "Third"
        item = priorityQueue.Dequeue();
        Assert.AreEqual("Third", item, "Expected Third item last.");
    }

    // Add more test cases as needed below.
}