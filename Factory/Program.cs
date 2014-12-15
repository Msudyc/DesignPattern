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
            // Register
            ProductFactory.Instance().RegisterProduct("ID01", new ProductA());
            ProductFactory.Instance().RegisterProduct("ID02", new ProductB());

            List<string> ids = new List<string>();
            ids.Add("ID01");
            ids.Add("ID02");

            Console.Write("Input product id: ");
            ids.ForEach(e => Console.Write("\t{0}", e));
            Console.WriteLine();

            string id = string.Empty;
            while(id != "x")
            {
                id = Console.ReadLine();
                if (ids.Contains(id))
                {
                    // Client is not aware of concrete product
                    Product product = ProductFactory.Instance().CreateProduct(id);
                    product.Print();
                }
                else
                {
                    Console.WriteLine("Wrong ID!");
                }
            }
        }
    }
}
