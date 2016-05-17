using System.Collections.Generic;

namespace UnityUtils.EventUtils {
    public class Event {
        public delegate void Listener();

        private List<Listener> listeners;

        public Event() {
            listeners = new List<Listener>();
        }

        public void Subscribe(Listener listener) {
            listeners.Add(listener);
        }

        public void Unsubscribe(Listener listener) {
            listeners.Remove(listener);
        }

        public void Trigger() {
            foreach (Listener listener in listeners) {
                listener();
            }
        }
    }

    public class Event<Arg0> {
        public delegate void Listener(Arg0 arg0);

        private List<Listener> listeners;

        public Event() {
            listeners = new List<Listener>();
        }

        public void Subscribe(Listener listener) {
            listeners.Add(listener);
        }

        public void Unsubscribe(Listener listener) {
            listeners.Remove(listener);
        }

        public void Trigger(Arg0 arg0) {
            foreach (Listener listener in listeners) {
                listener(arg0);
            }
        }
    }

    public class Event<Arg0, Arg1> {
        public delegate void Listener(Arg0 arg0, Arg1 arg1);

        private List<Listener> listeners;

        public Event() {
            listeners = new List<Listener>();
        }

        public void Subscribe(Listener listener) {
            listeners.Add(listener);
        }

        public void Unsubscribe(Listener listener) {
            listeners.Remove(listener);
        }

        public void Trigger(Arg0 arg0, Arg1 arg1) {
            foreach (Listener listener in listeners) {
                listener(arg0, arg1);
            }
        }
    }

    public class Event<Arg0, Arg1, Arg2> {
        public delegate void Listener(Arg0 arg0, Arg1 arg1, Arg2 arg2);

        private List<Listener> listeners;

        public Event() {
            listeners = new List<Listener>();
        }

        public void Subscribe(Listener listener) {
            listeners.Add(listener);
        }

        public void Unsubscribe(Listener listener) {
            listeners.Remove(listener);
        }

        public void Trigger(Arg0 arg0, Arg1 arg1, Arg2 arg2) {
            foreach (Listener listener in listeners) {
                listener(arg0, arg1, arg2);
            }
        }
    }

    public class Event<Arg0, Arg1, Arg2, Arg3> {
        public delegate void Listener(Arg0 arg0, Arg1 arg1, Arg2 arg2, Arg3 arg3);

        private List<Listener> listeners;

        public Event() {
            listeners = new List<Listener>();
        }

        public void Subscribe(Listener listener) {
            listeners.Add(listener);
        }

        public void Unsubscribe(Listener listener) {
            listeners.Remove(listener);
        }

        public void Trigger(Arg0 arg0, Arg1 arg1, Arg2 arg2, Arg3 arg3) {
            foreach (Listener listener in listeners) {
                listener(arg0, arg1, arg2, arg3);
            }
        }
    }
}