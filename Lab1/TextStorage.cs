using System;

namespace Lab1
{
    public class TextStorage
    {
        string _text;


        /**
         * Getter method for the text string.
        */
        public string GetText()
        {
            return _text;
        }

        /**
         * Setter method for the text string. 
         * The new string is added to the end of
         * the previous string. Becomes an empty string
         * if the contents of _text is null.
         * 
         * parameter text: The new text to add
        */
        public void SetText(string text)
        {
            if (_text == null)
            {
                _text = "";
            }

            _text += text;
        }

        /**
         * Overwrites the current text with a 
         * brand new string. This is used when
         * the undo functionality is accessed.
         * 
         * parameter newText: The desired text, 
         * which was previously backed up on stack.
        */
        public void RestoreStorage(string newText)
        {
            _text = newText;
        }

        /**
         * Creates a SnapShot, i.e. a backup, 
         * of this TextStorage object. 
         * 
         * returns: A backup to be placed on stack
        */
        public SnapShot CreateSnapshot()
        {
            return new SnapShot(this, _text);
        }
    }
}
