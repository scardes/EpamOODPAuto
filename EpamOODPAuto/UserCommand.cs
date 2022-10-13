using System;
using System.Collections.Generic;
using System.Text;

namespace EpamOODPAuto
{
    class UserCommand : ICommand
    {
        public void Execute()
        {
            AutoSingleBase s1 = AutoSingleBase.GetAutoBase();
            s1.singeletonLogic();
        }
    }
}
