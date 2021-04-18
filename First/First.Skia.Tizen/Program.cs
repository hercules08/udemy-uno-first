using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace First.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new First.App(), args);
            host.Run();
        }
    }
}
