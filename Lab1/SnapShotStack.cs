using System.Collections;

namespace Lab1
{
    public static class SnapShotStack
    {
        static readonly Stack stack = new Stack();


        public static void PushToStack(SnapShot snapShot)
        {
            stack.Push(snapShot);
        }

        public static SnapShot PopFromStack()
        {
            if (stack.Count == 0)
            {
                return null;
            }

            return (SnapShot) stack.Pop();
        }
    }
}
