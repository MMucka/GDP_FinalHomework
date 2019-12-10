using System;
using System.Collections.Generic;
using Assets.Scripts.CommandPattern;
using TMPro;
using UnityEngine;

namespace Assets.Scripts
{
    class Commands : ICommandPattern
    {
        public static Commands Instance { get; } = new Commands();      //Singleton init
        private Queue<ByteCodes.Codes> _codesQueue;               //FIFO queue
        //private Queue<ICommandPattern> _commandsQueue;     

        private Commands()
        {   //init new queue
            _codesQueue = new Queue<ByteCodes.Codes>();
        }

        /*
         * Add new command
         * @code - new code commnad
         */
        public void AddCode(ByteCodes.Codes code)
        {
            _codesQueue.Enqueue(code);
        }

        /*
         * Execute command
         */
        public override void Execute()
        {
            if (_codesQueue.Count != 0)
            {
                ByteCodes.Codes code = _codesQueue.Dequeue();
                switch (code)
                {
                    case ByteCodes.Codes.Hit:
                        ByteCodes.Codes objectCode = _codesQueue.Dequeue();
                        GameObject hitObject = GameObject.Find(objectCode.ToString());
                        new HitCommand(hitObject).Execute();
                        break;

                    case ByteCodes.Codes.IncrementScore:
                        TMP_Text scoreText = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
                        scoreText.SetText(scoreText.text+".");
                        break;

                    case ByteCodes.Codes.Move:
                        
                        break;
                    case ByteCodes.Codes.EndGame:
                        
                        break;
                    default:
                        Debug.Log("Unknown code");
                        break;
                }
            }
        }

        /*
         * Undo command
         */
        public override void UnExecute()
        {
            //if (_commandsQueue.Count != 0)
            //    _commandsQueue.Dequeue().UnExecute();
        }
    }
}
