namespace DesignPattern
{
    #region using
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            List<Creator> creators = new List<Creator>();
            creators.Add(new CreatorA());
            creators.Add(new CreatorB());
            creators.Add(new CreatorB());
            creators.Add(new CreatorA());
            creators.Add(new CreatorB());

            foreach (var creator in creators)
                products.Add(creator.CreateProduct());

            foreach (var product in products)
                product.Print();

            Console.ReadLine();
        }
    }
}
