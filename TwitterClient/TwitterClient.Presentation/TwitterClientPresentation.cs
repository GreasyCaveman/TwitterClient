using System.Windows.Forms;

namespace TwitterClient.Presentation
{
    public class TwitterClientPresentation
    {

       public static void Init()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DisplayContainer());
        }
    }
}
