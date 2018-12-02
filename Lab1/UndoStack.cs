using System.Collections;

namespace Lab1
{
    public static class UndoStack
    {
        static readonly Stack undoStack = new Stack();


        /**
         * Returns true if the stack is completely empty
        */       
        public static bool IsEmpty()
        {
            return undoStack.Count == 0;
        }

        /**
         * Places the provided SnapShot on top
         * of the stack.
         * 
         * parameter snapShot: The one to put on top of the stack
        */
        public static void PushToStack(SnapShot snapShot)
        {
            undoStack.Push(snapShot);
        }

        /**
         * Gets the SnapShot that is at the top
         * of the Stack without removing it.
        */
        public static SnapShot PeekAtStack()
        {
            if (undoStack.Count == 0) {
                return null;
            }
            return (SnapShot) undoStack.Peek();
        }

        /**
         * Gets the SnapShot that is at the top
         * of the Stack. It is also removed entirely from the stack.
         * Returns a SnapShot unless the number of 
         * objects in stack are zero. Then, null is returned.
        */
        public static SnapShot PopFromStack()
        {
            if (undoStack.Count == 0)
            {
                return null;
            }

            return (SnapShot) undoStack.Pop();
        }
    }
}
