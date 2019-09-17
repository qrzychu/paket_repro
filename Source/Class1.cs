using System;
using System.Reactive.Linq;

namespace paket_repro
{
    public class Class1
    {
        public void DoStuff()
        {
            Observable.Return(5).Subscribe(x => Console.WriteLine(x));
        }
    }
}
