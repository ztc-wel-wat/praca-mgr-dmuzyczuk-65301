using System;
using System.Collections.Generic;

namespace Aplikacja_MEMS.Analysis
{
    class Data<T>
    {
        private readonly Queue<T> queue = new Queue<T>();
        public event EventHandler Changed;
        protected virtual void OnChanged()
        {
            if (Changed != null) Changed(this, EventArgs.Empty);
        }
        public virtual void Enqueue(T item)
        {
            queue.Enqueue(item);
            OnChanged();
        }
        public int Count { get { return queue.Count; } }

        public virtual T Dequeue()
        {
            T item = queue.Dequeue();
            return item;
        }
    }
}
