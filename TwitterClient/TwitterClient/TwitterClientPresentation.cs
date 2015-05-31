using System.Windows.Forms;
using TwitterClient.Presentation.Frontend;

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
