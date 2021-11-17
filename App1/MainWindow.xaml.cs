using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI;
using System;
using WinRT.Interop;
using App1.View.Pages;

namespace App1;

public sealed partial class MainWindow : Window
{
    private AppWindow m_appWindow;
    public int MyNumber { get; set; }
    public MainWindow()
    {
        this.InitializeComponent();
        m_appWindow = GetAppWindowForCurrentWindow();
        if (m_appWindow != null)
        {
            MyTitleBar.Height = m_appWindow.Size.Height - Bounds.Height;
            ExtendsContentIntoTitleBar = true;
            SetTitleBar(MyTitleBar);
        }
        MainFrame.Navigate(typeof(MainPage));
    }

    private AppWindow GetAppWindowForCurrentWindow()
    {
        IntPtr hWnd = WindowNative.GetWindowHandle(this);
        WindowId myWndId = Win32Interop.GetWindowIdFromWindow(hWnd);
        return AppWindow.GetFromWindowId(myWndId);
    }
}
