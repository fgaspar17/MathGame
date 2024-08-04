using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GameRecord
    {
        public int Id {  get; set; }
        public string Operation { get; set; }
        public int Result { get; set; }
        public int Seconds { get; set; }
        public GameRecord(int id, string operation, int result, int seconds) 
        { 
            Id = id;
            Operation = operation;
            Result = result;
            Seconds = seconds;
        }
        public override string ToString()
        {
            return $"{Id}. {Operation} = {Result}, {Seconds}s";
        }
    }
}
