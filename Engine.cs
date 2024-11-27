using System.Runtime.CompilerServices;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace ExodusEngine;

public class Engine
{
    private readonly IWindow _window;
    
    public Engine()
    {
        var windowOptions = WindowOptions.Default;
        windowOptions.Title = "ExodusEngine";
        windowOptions.Size = new Vector2D<int>(1600, 900);

        _window = Window.Create(windowOptions);
    }

    private void Update(double delta)
    {
        
    }

    public void Run()
    {
        _window.Run();
    }
    
    public IWindow SilkWindow
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get => _window;
    }
}