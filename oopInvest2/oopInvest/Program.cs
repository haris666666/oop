using System;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace oopInvest
{
    class main
    {
        static void Main()
        {
            JSONSave _js = new JSONSave();
            Investment _invest = new Investment();
            _invest = _js.LoadJSON(_invest);
            _invest.Start();
            _invest = _js.SaveJSON(_invest);
        }
    }
}
//0.3.20 Инвестирование свободных средств
