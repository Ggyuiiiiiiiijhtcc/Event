using System;

class KeyListener
{
    public event EventHandler EnterKeyPressed;
    public event EventHandler SpaceKeyPressed;
    public event EventHandler EscapeKeyPressed;
    public event EventHandler F1KeyPressed;
    public event EventHandler LeftKeyPressed;
    public event EventHandler RightKeyPressed;
    public event EventHandler UpKeyPressed;
    public event EventHandler DownKeyPressed;
    public void Listen()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    EnterKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.Spacebar:
                    SpaceKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.Escape:
                    EscapeKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.F1:
                    F1KeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.LeftArrow:
                    LeftKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.RightArrow:
                    RightKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.UpArrow:
                    UpKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
                case ConsoleKey.DownArrow:
                    DownKeyPressed?.Invoke(this, EventArgs.Empty);
                    break;
            }
        }
    }
}
class Person
{
    private readonly KeyListener _keyListener;
    public Person()
    {
        _keyListener = new KeyListener();
        _keyListener.SpaceKeyPressed += OnSpaceKeyPressed;
        _keyListener.EnterKeyPressed += OnEnterKeyPressed;
        _keyListener.LeftKeyPressed += OnLeftKeyPressed;
        _keyListener.RightKeyPressed += OnRightKeyPressed;
        _keyListener.UpKeyPressed += OnUpKeyPressed;
        _keyListener.DownKeyPressed += OnDownKeyPressed;
    }

    public void Start()
    {
        Console.WriteLine("Нажмите Пробел для прыжка, Enter для выбора, стрелки для перемещения, или Esc для выхода...");
        _keyListener.Listen();
    }

    private void OnSpaceKeyPressed(object sender, EventArgs e)
    {
        Console.WriteLine("Jump!");
    }

    private void OnEnterKeyPressed(object sender, EventArgs e)
    {
        Console.WriteLine("Select!");
    }

    private void OnLeftKeyPressed(object sender, EventArgs e)
    {
        Console.WriteLine("Move left!");
    }

    private void OnRightKeyPressed(object sender, EventArgs e)
    {
        Console.WriteLine("Move right!");
    }

    private void OnUpKeyPressed(object sender, EventArgs e)
    {
        Console.WriteLine("Move up!");
    }

    private void OnDownKeyPressed(object sender, EventArgs e)
    {
        Console.WriteLine("Move down!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Start();
    }
}