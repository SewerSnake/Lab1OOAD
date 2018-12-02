using System;

namespace Lab1
{
    public class SnapShot
    {
        readonly TextStorage textStorage;

        readonly string text;

       
        /**
         * The two parameters are assigned.
         * 
         * parameter textStorage: The TextStorage object to save
         * parameter text: The string which the user wrote in console
        */
        public SnapShot(TextStorage textStorage, string text)
        {
            this.textStorage = textStorage;
            this.text = text;
        }

        /**
         * An older TextStorage is loaded using a memento object.
         * Allows Redo functionality by saving this SnapShot
         * to another stack.
         * Makes sure that text is empty if a backup doesn't exist.
        */
        public void Undo()
        {
            if (UndoStack.PeekAtStack() != null)
            {
                RedoStack.PushToStack(UndoStack.PeekAtStack());
            }

            SnapShot backup = UndoStack.PopFromStack();

            if (backup == null)
            {
                textStorage.RestoreStorage("");
            }
            else 
            {
                textStorage.RestoreStorage(backup.text);
            }
        }

        /**
         * A newer TextStorage is loaded using a memento object.
        */
        public void Redo()
        {
            SnapShot backup = RedoStack.PopFromStack();

            if (backup != null)
            {
                textStorage.RestoreStorage(backup.text);
            }
        }
    }
}
