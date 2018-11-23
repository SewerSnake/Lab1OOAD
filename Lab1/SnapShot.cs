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
         * parameter text: The string which the user wrote in terminal
        */
        public SnapShot(TextStorage textStorage, string text)
        {
            this.textStorage = textStorage;
            this.text = text;
        }

        /**
         * Old TextStorage is restored using a memento object.
         * Makes sure that text is empty if a backup doesn't exist.
        */
        public void Restore()
        {
            SnapShot backup = SnapShotStack.PopFromStack();

            if (backup == null)
            {
                textStorage.RestoreStorage("");
            }
            else 
            {
                textStorage.RestoreStorage(backup.text);
            }
        }
    }
}
