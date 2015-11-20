using System;
using Eto.Forms;
using Rhino;

namespace SampleCsEto
{
  public static class SampleCsEtoHelpers
  {
    /// <summary>
    /// Converts a native window handle to an Eto.Forms window to use for setting parent of dialogs, etc.
    /// </summary>
    /// <param name="handle">Native handle of the window to get</param>
    /// <returns>A new instance of a window that wraps the native window instance</returns>
    public static Window GetEtoWindow(IntPtr handle)
    {
      var handler = new Eto.Wpf.Forms.HwndFormHandler(handle);
      return new Form(handler);
    }

    /// <summary>
    /// Gets a Form attached to the main Rhino window.
    /// </summary>
    /// <value>Returns a Form attached to the main Rhino window.</value>
    public static Window MainWindow
    {
      get
      {
        return (g_main_window ?? (g_main_window = GetEtoWindow(RhinoApp.MainWindowHandle())));
      }
    }
    private static Window g_main_window;
  }
}
