/*
Name: Singleton

Definition:
Ensure a class has only one instance and provide a global point of access to it. 

Frequency of use: Medium high

Applicability & Examples:
Logger Classes, Configuration Classes
Accesing resources in shared mode
Factories implemented as Singletons

*/

namespace DesignPattern
{
    using System;

    public class Singleton
    {
        private static Singleton instance;
        private static object syncRoot = new Object();

        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }

            return instance;
        }
    }
}