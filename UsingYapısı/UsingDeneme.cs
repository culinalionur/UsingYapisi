using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingYapısı
{
    public class UsingDeneme : IDisposable
    {
        public bool IsDisposed { get; private set; } = false;
        public void Dispose()
        {
            IsDisposed= true; 
        }
        public void Show()
        {
            Console.WriteLine("Using yapısı denemesi yapılıyor.");
            Console.WriteLine("Dispose status {0}", IsDisposed);
        }
    }
}
