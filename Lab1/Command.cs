using System;

namespace Lab1
{
    public class Command
    {
        SnapShot backup;


        /**
         * Makes a backup by creating a snapshot 
         * of the provided TextStorage.
         * 
         * parameter storage: The TextStorage object to create a backup of
        */
        public void MakeBackup(TextStorage storage)
        {
            backup = storage.CreateSnapshot();
            SnapShotStack.PushToStack(backup);
        }

        /**
         * If there exists a backup, it will be used to obtain
         * text previously written by the user.
        */
        public void Undo()
        {
            if (backup != null)
            {
                backup.Restore();
            }
        }
    }
}
