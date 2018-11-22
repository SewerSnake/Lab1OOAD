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
         * Old TextStorage is restored using a memento object
        */
        public void Restore()
        {
            textStorage.RestoreStorage(text);
        }
    }
}
