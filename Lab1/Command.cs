using System;

namespace Lab1
{
    public class Command
    {
        SnapShot backup;


        public void MakeBackup(TextStorage storage)
        {
            backup = storage.CreateSnapshot();
        }

        public void Undo()
        {
            if (backup != null)
            {
                backup.Restore();
            }
        }
    }
}
