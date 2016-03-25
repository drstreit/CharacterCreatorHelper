using System;
using System.Runtime.InteropServices;

namespace CharacterCreatorHelper
{
    internal class User32Wrapper
    {
        public enum Gwl
        {
            ExStyle = -20
        }

        [Flags]
        public enum WsEx
        {
            Transparent = 0x20,
            Layered = 0x80000
        }

        public enum Lwa
        {
            Color = 0x1,
            Alpha = 0x2
        }

        [DllImport(@"user32", EntryPoint = @"GetWindowLong")]
        public static extern int GetWindowLong(
        IntPtr hWnd,
        Gwl nIndex);

        [DllImport(@"user32", EntryPoint = @"SetWindowLong")]
        public static extern int SetWindowLong(
        IntPtr hWnd,
        Gwl nIndex,
        WsEx dsNewLong);

        [DllImport(@"user32.dll", EntryPoint = @"SetLayeredWindowAttributes")]
        public static extern bool SetLayeredWindowAttributes(
        IntPtr hWnd,
        int crKey,
        byte alpha,
        Lwa dwFlags);
    }
}
