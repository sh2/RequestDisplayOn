using Windows.System.Display;

namespace RequestDisplayOn
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            DisplayRequest displayRequest = new DisplayRequest();

            displayRequest.RequestActive();
            Console.WriteLine("ディスプレイへの表示要求をアクティブ化しました。");
            Console.WriteLine("続けるにはEnterキーを押してください。");
            Console.ReadLine();

            displayRequest.RequestRelease();
            Console.WriteLine("ディスプレイへの表示要求をリリースしました。");
            Console.WriteLine("続けるにはEnterキーを押してください。");
            Console.ReadLine();
        }
    }
}
