using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions; 

namespace WcfServiceHost
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string QuantityPerUnit { get; set; }
        [DataMember]
        public Nullable<decimal> UnitPrice { get; set; }
        [DataMember]
        public Nullable<short> UnitsInStock { get; set; }
        [DataMember]
        public Nullable<short> UnitsOnOrder { get; set; }
        [DataMember]
        public Nullable<short> ReorderLevel { get; set; }
        [DataMember]
        public bool Discontinued { get; set; }

        internal static Expression<Func<NorthwindDB.Product, Product>> FromEF
        {
            get {
                return p => new Product
                    {
                        ID = p.ProductID,
                        Name = p.ProductName,
                        Discontinued = p.Discontinued,
                        QuantityPerUnit = p.QuantityPerUnit,
                        ReorderLevel = p.ReorderLevel,
                        UnitPrice = p.UnitPrice,
                        UnitsInStock = p.UnitsInStock,
                        UnitsOnOrder = p.UnitsOnOrder,
                    };
            }
        }
    }

    [ServiceContract]
    public interface INorthwindService
    {
        [OperationContract]
        Task<IEnumerable<string>> GetCategories();

        [OperationContract]
        Task<IEnumerable<Product>> GetProductsByCategory(string category);
    }

    class NorthwindService : INorthwindService
    {
        public async Task<IEnumerable<string>> GetCategories()
        {
            using (var db = new NorthwindDB.NorthwindEntities())
            {
                return await db.Categories
                    .Select(cat => cat.CategoryName)
                    .ToListAsync();
            }
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string category)
        {
            using (var db = new NorthwindDB.NorthwindEntities())
            {
                var cat = await db.Categories.Where(c => c.CategoryName == category).FirstAsync();

                return await db.Products
                    .Where(prod => prod.CategoryID == cat.CategoryID)
                    .Select(Product.FromEF)
                    .ToListAsync();
            }
        }
    }
}
