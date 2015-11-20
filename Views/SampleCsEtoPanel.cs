using Eto.Drawing;
using Eto.Forms;
using Rhino.UI;
using RhinoWindows.Controls;

namespace SampleCsEto.Views
{
  /// <summary>
  /// Required class GUID, used as the panel Id
  /// </summary>
  [System.Runtime.InteropServices.Guid("0E7780CA-F004-4AE7-B918-19E68BF7C7C9")]
  public class SampleCsEtoPanel : Panel, System.Windows.Forms.IWin32Window
  {
    private WpfElementHost m_element_host;

    /// <summary>
    /// Provide easy access to the SampleEtoPanel.GUID
    /// </summary>
    public static System.Guid PanelId
    {
      get { return typeof(SampleCsEtoPanel).GUID; }
    }

    /// <summary>
    /// Provide easy access to the panel, this will be null until the panel has
    /// been opened at least once.
    /// </summary>
    public static SampleCsEtoPanel Panel
    {
      get { return (Panels.GetPanel(PanelId) as SampleCsEtoPanel); }
    }

    /// <summary>
    /// Required public constructor with NO parameters
    /// </summary>
    public SampleCsEtoPanel()
    {
      Title = GetType().Name;

      var hello_button = new Button { Text = "Hello" };
      hello_button.Click += (sender, e) => OnHelloButton();

      var layout = new DynamicLayout { DefaultSpacing = new Size(5, 5), Padding = new Padding(10) };
      layout.AddSeparateRow(hello_button, null);
      layout.Add(null);
      Content = layout;
    }

    public string Title { get; private set; }

    protected void OnHelloButton()
    {
      MessageBox.Show(this, "Hello Rhino!", Title, MessageBoxButtons.OK);
    }

    public System.IntPtr Handle
    {
      get
      {
        if (null != m_element_host)
          return m_element_host.Handle;

        var element = this.ToNative(true);
        if (null != element)
        {
          m_element_host = new WpfElementHost(element, null);
          if (null != m_element_host)
            return m_element_host.Handle;
        }

        return NativeHandle; // this probably should just be IntPtr.Zero
      }
    }
  }
}
