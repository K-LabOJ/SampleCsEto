namespace SampleCsEto
{
  public class SampleCsEtoPlugIn : Rhino.PlugIns.PlugIn
  {
    public SampleCsEtoPlugIn()
    {
      Application = new Eto.Forms.Application(Eto.Platforms.Wpf);
      Instance = this;
    }

    public static SampleCsEtoPlugIn Instance
    {
      get;
      private set;
    }

    public Eto.Forms.Application Application { get; private set; }
  }
}