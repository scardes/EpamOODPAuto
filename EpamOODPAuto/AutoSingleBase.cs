using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Singleton class of Auto Database
/// </summary>
namespace EpamOODPAuto
{
    public sealed class AutoSingleBase
    {
        private AutoSingleBase() { }

        private static AutoSingleBase _instance;

        public static AutoSingleBase GetAutoBase()
        {
            if (_instance == null)
            {
                _instance = new AutoSingleBase();
            }
            return _instance;
        }

        public void businessLogic(string text)
        {
            Console.WriteLine(text);
        }

    }
}
