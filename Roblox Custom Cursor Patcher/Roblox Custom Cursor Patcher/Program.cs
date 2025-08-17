namespace Roblox_Custom_Cursor_Patcher
{
    using System.Timers;

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string customCursorPath = "";
        }

        class CursorManager 
        {
            public string customCursorPath = string.Empty;

            public static void SetCustomCursor(string path_to_cursor_to_replace, string path_to_custom_cursor)
            {

            }
        }

        class CursorWatcher
        {
            private Timer timer;
            private string cursorPath;

            public CursorWatcher(string path)
            {
                cursorPath = path;
                timer = new Timer(2000);
                timer.Elapsed += (s, e) => CursorManager.SetCustomCursor(cursorPath);
            }
        }
    }
}