﻿namespace LazyInitialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.Instance;
            singleton.Write();
        }
    }
}