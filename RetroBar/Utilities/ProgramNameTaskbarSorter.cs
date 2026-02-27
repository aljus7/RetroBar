using ManagedShell.WindowsTasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RetroBar.Utilities
{
    internal class ProgramNameTaskbarSorter : IComparer
    {
        public int Compare(object x, object y)
        {
            var winA = x as ApplicationWindow;
            var winB = y as ApplicationWindow;
            if (winA == null || winB == null) return 0;

            // Use WinFileName as a substitute for ProcessName
            int cmp = string.Compare(winA.WinFileName, winB.WinFileName, StringComparison.OrdinalIgnoreCase);
            if (cmp != 0) return cmp;

            // Fallback: sort by window title
            return string.Compare(winA.Title, winB.Title, StringComparison.OrdinalIgnoreCase);
        }
    }
}
