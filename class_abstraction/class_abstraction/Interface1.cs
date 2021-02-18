using System;
using System.Collections.Generic;
using System.Text;

namespace class_abstraction
{
    public interface IQuitting
    {
        // any class that inherits this interface must implement this method
        void Quit();
    }
}
