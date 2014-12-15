/*
Name: Factory

Definition:
Creates objects without exposing the instantiation logic to the client.
Refers to the newly created object through a common interface.

Frequency of use: High

Applicability & Examples:
Graphical application works with shapes.
The framework uses the object as casted to the abstract class without being
aware of the concrete object type. New shapes can be added without changing 
a single line of code in the framework (the client code that uses the shapes 
from the factory). 

*/

namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class ProductFactory
    {
        private Dictionary<string, Product> map;
        private static ProductFactory instance;
        private static object syncRoot = new Object();

        private ProductFactory()
        {
            this.map = new Dictionary<string, Product>();
        }

        public void RegisterProduct(string id, Product product)
        {
            if (!this.map.ContainsKey(id))
            {
                this.map.Add(id, product);
            }
        }

        public Product CreateProduct(string id)
        {
            if (!this.map.ContainsKey(id))
                return null;

            return this.map[id].CreateProduct();
        }

        public static ProductFactory Instance()
        {
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new ProductFactory();
                    }
                }
            }

            return instance;
        }
    }
}