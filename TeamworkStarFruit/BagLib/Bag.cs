﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib;
using ExceptionLib;

namespace BagLib
{
    public class Bag : IChangeable
    {
        public List<Product> productsInBag { get; set; }

        public Bag()
        {
            this.productsInBag = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
            // TO DO
        }

        public void RemoveProduct(int id)
        {
            bool hasBeenRemoved = false;
            foreach (var product in this.productsInBag)
            {
                if (product.ID == id)
                {
                    this.productsInBag.Remove(product);
                    hasBeenRemoved = true;
                    break;
                }
            }
            if (!hasBeenRemoved)
            {
                throw new ProductNotFoundException("There is not such a product in your bag.");
            }
        }

        public void RemoveAll()
        {
            productsInBag.Clear();
        }

        public override string ToString()
        {
            StringBuilder products = new StringBuilder();
            foreach (var product in productsInBag)
            {
                products.Append(product + "\n");
            }
            return products.ToString();
        }
    }
}