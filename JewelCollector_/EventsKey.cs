using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace JewelCollector_
{
    public class EventsKey:HandledEventArgs 
    {
        public ConsoleKeyInfo key;
        public EventsKey(ConsoleKeyInfo _key)
        {
            key = _key;
        }
    }

    public class KeyPressed
    {
        public event EventHandler<EventsKey> KeyPress;
        // public event EventHandler<EventsKey> OnKeyWPressed;
        // public event EventHandler<EventsKey> OnKeyAPressed;
        // public event EventHandler<EventsKey> OnKeySPressed;
        // public event EventHandler<EventsKey> OnKeyDPressed;
        public void OnKeyPress(ConsoleKeyInfo _key)
        {
            KeyPress(this, new EventsKey(_key));
            // OnKeyWPressed(this, new EventsKey(_key));
            // OnKeyAPressed(this, new EventsKey(_key));
            // OnKeySPressed(this, new EventsKey(_key));
            // OnKeyDPressed(this, new EventsKey(_key));
        }
    }
}




