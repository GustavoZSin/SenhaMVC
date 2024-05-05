namespace SenhaMVC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SenhaView senhaView = new SenhaView();
            senhaView.Visible = false;

            SenhaModel senhaModel = new SenhaModel();

            SenhaController senhaController = new SenhaController(senhaView, senhaModel);
            senhaView.ShowDialog();
        }
    }
}