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
        public GameRecord(int id, string operation, int result) 
        { 
            Id = id;
            Operation = operation;
            Result = result;
        }
        public override string ToString()
        {
            return $"{Id}. {Operation} = {Result}";
        }
    }
}
