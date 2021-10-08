using System;

namespace Delegate
{
    public class MyKitchen
    {
        void Run()
        {
            Recept cake = new Recept();
            cake.Then((() => { Console.WriteLine("Возьмите муку"); }));
            cake.Then((() => { Console.WriteLine("Возьмите сыр"); }));

            cake.Make();
        }
    }

    public class Recept
    {
        private Action Posledovatelnost;
        public Action<string> OnError = s => { Console.WriteLine(s); };

        public void Then(Action a)
        {
            Posledovatelnost += a;
        }

        public void Make()
        {
            try
            {
                Posledovatelnost();
            }
            catch (Exception ex)
            {
                OnError(ex.Message);
            }
        }
    }
}