using SFML.Graphics;
using SFML.Window;

namespace Tag_Ur_IT_GUI;

public static class Program
{
    public static void Main(string[] args)
    {
        var displayMode = new VideoMode(1600, 900);
        var window = new RenderWindow(displayMode, "Test");

        // actually exit when you press the "X" button
        window.Closed += (_, _) => window.Close();
        

        while (window.IsOpen)
        {
            window.DispatchEvents();
            //window.Draw(render);
            window.Display();
        }
        
    }
}