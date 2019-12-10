using UnityEngine;
using System.Collections.Generic;
using CommandPatternExample;

public class InputHandler : MonoBehaviour
{
    public float speed = 8.0f;
    public GameObject objectToMove;

    private MoveCommandReceiver moveCommandReciever;
    private List<MoveCommand> commands = new List<MoveCommand>();
    private int currentCommandNum = 0;

    void Start()
    {
        moveCommandReciever = new MoveCommandReceiver();

        if (objectToMove == null)
        {
            Debug.LogError("objectToMove must be assigned via inspector");
            this.enabled = false;
        }
    }


    public void Undo()
    {
        if (currentCommandNum > 0)
        {
            currentCommandNum--;
            MoveCommand moveCommand = commands[currentCommandNum];
            moveCommand.UnExecute();
        }
    }

    public void Redo()
    {
        if (currentCommandNum < commands.Count)
        {
            MoveCommand moveCommand = commands[currentCommandNum];
            currentCommandNum++;
            moveCommand.Execute();
        }
    }

    private void Move()
    {
        MoveCommand moveCommand = new MoveCommand(moveCommandReciever, speed, objectToMove);
        moveCommand.Execute();
        commands.Add(moveCommand);
        currentCommandNum++;
    }
    
    //Shows what's going on in the command list
    
}