using System;

namespace Lab1
{
    public class SnapShot
    {
        readonly TextStorage textStorage;

        readonly string text;


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
