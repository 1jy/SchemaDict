using Gma.System.MouseKeyHook;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchemaDict.Class
{
    class Picker
    {
        [DllImport("user32.dll")]
        public static extern int SetClipboardViewer(int windowHandle); //安装剪切板监听

        [DllImport("user32.dll")]
        public static extern int ChangeClipboardChain(int removeWindowHandle, int nextWindowHandle);

        private IKeyboardMouseEvents m_GlobalHook;
        private static int nextPtr;
        public MouseEventArgs MouseEventArgs;
        public Picker(IntPtr handle)
        {
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.MouseDoubleClick += async (obj, args) => await this.MouseDoubleClicked(obj, args);
            nextPtr = SetClipboardViewer(handle.ToInt32());
        }

        private async Task MouseDoubleClicked(object sender, MouseEventArgs e)
        {
            MouseEventArgs = e;
            await Task.Run(() =>
            {
                SendKeys.SendWait("^c");
            });
        }

        public void Dispose(){
            SetClipboardViewer(nextPtr);
            m_GlobalHook.Dispose();
        }
    }
}
