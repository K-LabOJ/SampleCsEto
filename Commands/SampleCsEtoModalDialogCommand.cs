namespace SampleCsEto.Commands
{
  [System.Runtime.InteropServices.Guid("3effa6c1-ae59-463e-8c86-ee727044308e")]
  public class SampleCsEtoModalDialogCommand : Rhino.Commands.Command
  {
    public override string EnglishName
    {
      get { return "SampleCsEtoModalDialog"; }
    }

    protected override Rhino.Commands.Result RunCommand(Rhino.RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      var dialog = new Views.SampleCsEtoModalDialog();
      var rc = dialog.ShowModal(SampleCsEtoHelpers.MainWindow);
      return (rc == Eto.Forms.DialogResult.Ok) ? Rhino.Commands.Result.Success : Rhino.Commands.Result.Cancel;
    }
  }
}
