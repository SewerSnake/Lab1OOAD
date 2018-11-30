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
            UndoStack.PushToStack(backup);
        }

        /**
         * If there exists a backup, it will be used to obtain
         * older text written by the user.
        */
        public void Undo()
        {
            if (backup != null)
            {
                backup.Undo();
            } 
            else
            {
                Console.WriteLine("There is nothing to undo...\n");
            }
        }

        /**
         * If there exists a backup, it will be used to obtain
         * newer text written by the user.
        */
        public void Redo()
        {
            if (backup != null)
            {
                backup.Redo();
            } else {
                Console.WriteLine("There is nothing to redo...\n");
            }
        }
    }
}
