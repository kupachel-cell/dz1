using System;


namespace dz1tum.stren
{
    public struct bankacc
    {
        public int Number { get; set; }
        public string Type { get; set; }
        public double Balance { get; set; }
        public bankacc(int number, string type, double balance)
        {
            Number = number;
            Type = type;
            Balance = balance;
        }
    }
    public struct worker
    {
        public string Name { get; set; }
        public int Workplace { get; set; }
       
    }
    
    public class structs
    {
       
    }
}
