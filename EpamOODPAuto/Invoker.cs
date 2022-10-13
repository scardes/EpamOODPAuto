using System;
using System.Collections.Generic;
using System.Text;

namespace EpamOODPAuto
{
    class Invoker
    {
        private ICommand _onStart;

        // Инициализация команд
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        // Отправитель не зависит от классов конкретных команд и получателей.
        // Отправитель передаёт запрос получателю косвенно, выполняя команду.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Programm start");
            if (this._onStart is ICommand)
            {
                this._onStart.Execute();
            }
        }
    }
}
