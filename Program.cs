var light = new Light();
var lightOn = new LightOnCommand(light);
var lightOff = new LightOffCommand(light);
var door = new Door();
var doorOpen = new DoorOpenCommand(door);
var doorClose = new DoorCloseCommand(door);
var remote = new RemoteControl();

remote.SetCommand(doorOpen);
remote.PressButton();
remote.SetCommand(lightOn);
remote.PressButton();
remote.SetCommand(lightOff);
remote.PressButton();
remote.SetCommand(doorClose);
remote.PressButton();

public interface ICommand
{
    void Execute();
}

public class Light
{
    public void On()
    {
        Console.WriteLine("Light is ON");
    }

    public void Off()
    {
        Console.WriteLine("Light is OFF");
    }
}

public class LightOnCommand : ICommand
{
    private Light _light;
    public LightOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.On();
    }
}

public class LightOffCommand : ICommand
{
    private Light _light;
    public LightOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.Off();
    }
}

public class Door
{
    public void Open()
    {
        Console.WriteLine("Door is OPEN");
    }

    public void Close()
    {
        Console.WriteLine("Door is CLOSE");
    }
}

public class DoorOpenCommand : ICommand
{
    private Door _door;
    public DoorOpenCommand(Door door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Open();
    }
}

public class DoorCloseCommand : ICommand
{
    private Door _door;
    public DoorCloseCommand(Door door)
    {
        _door = door;
    }

    public void Execute()
    {
        _door.Close();
    }
}

public class RemoteControl
{
    private ICommand _command;
    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }
}
