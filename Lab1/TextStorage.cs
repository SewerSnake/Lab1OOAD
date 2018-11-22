using System;

namespace Lab1
{
    public class TextStorage
    {
        string _text;


        public string GetText()
        {
            return _text;
        }

        public void SetText(string text)
        {
            if (_text == null)
            {
                _text = "";
            }

            _text += text;
        }

        public void RestoreStorage(string newText)
        {
            _text = newText;
        }

        public SnapShot CreateSnapshot()
        {
            return new SnapShot(this, _text);
        }
    }
}
