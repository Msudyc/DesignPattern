namespace DesignPattern
{
    #region using
    using System;
    using System.Collections;
    #endregion

    public class ConcreteAggregate : Aggregate
    {
        private ArrayList items = new ArrayList();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        
        // Gets item count
        public int Count
        {
            get { return this.items.Count; }
        }
        
        // Indexe
        public object this[int index]
        {
            get { return this.items[index]; }
            set { this.items.Insert(index, value); }
        }
    }
}