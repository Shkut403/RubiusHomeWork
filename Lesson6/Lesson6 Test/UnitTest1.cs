namespace Lesson6
{
    using Xunit;

    public class StackTests
    {
        [Fact]
        public void PushAndPeek_SingleItem_ReturnsItem()
        {
            var stack = new Stack<int>();
            stack.Push(1);

            var result = stack.Peek();

            Assert.Equal(1, result);
        }

        [Fact]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Fact]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            var stack = new Stack<int>();

            var result = stack.IsEmpty();

            Assert.True(result);
        }

        [Fact]
        public void Clear_NonEmptyStack_EmptiesTheStack()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Clear();

            var result = stack.IsEmpty();

            Assert.True(result);
        }
    }
}