using supermarket.Views;

namespace supermarket
{
    internal static class Program
@@ -11,7 +13,7 @@ static void Main()
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Application.Run(new PayModeView());
        }
    }
}