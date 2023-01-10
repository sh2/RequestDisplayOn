using System.Reflection;
using Windows.System.Display;

namespace RequestDisplayOn
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();
            string name = assembly.Name ?? string.Empty;
            Version version = assembly.Version ?? new();
            Console.WriteLine($"{name} {version.Major}.{version.Minor}.{version.Build}");
            Console.WriteLine();

            DisplayRequest displayRequest = new();

            displayRequest.RequestActive();
            Console.WriteLine("ディスプレイへの表示要求を行いました。");
            Console.WriteLine("続けるにはEnterキーを押してください。");
            Console.ReadLine();

            displayRequest.RequestRelease();
            Console.WriteLine("ディスプレイへの表示要求を解除しました。");
            Console.WriteLine("続けるにはEnterキーを押してください。");
            Console.ReadLine();
        }
    }
}
