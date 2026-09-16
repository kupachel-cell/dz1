using System;


namespace dz1tum.stren
{
    public struct bankacc
    {
        public int Number;
        public string Type;
        public double Balance;
        public bankacc(int number, string type, double balance)
        {
            Number = number;
            Type = type;
            Balance = balance;
        }
    }
    public struct worker
    {
        public string Name;
        public UNI Workplace;
        public worker (string name, UNI workplace)
        {
            Name = name;
            Workplace = workplace;
        }
    }
    
    public class structs
    {
       
    }
}
