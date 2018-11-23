using System.Collections;

namespace Lab1
{
    public static class SnapShotStack
    {
        static readonly Stack stack = new Stack();


        /**
         * Places the provided SnapShot on top
         * of the stack.
         * parameter snapShot: The one to put on top of the stack
        */
        public static void PushToStack(SnapShot snapShot)
        {
            stack.Push(snapShot);
        }

        /**
         * Gets the SnapShot that is at the top
         * of the Stack. It is also removed entirely from the stack.
         * Returns a SnapShot unless the number of 
         * objects in stack are zero. Then, null is returned.
        */
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
