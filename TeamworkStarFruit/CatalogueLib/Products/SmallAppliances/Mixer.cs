﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogueLib.Products.Enumerations;

namespace CatalogueLib.Products
{
    public class Mixer : SmallAppliances
    {
        public Mixer(int ID, decimal price, bool isAvailable, Brand brand, double Capacity, double CableLength, int Affixes, bool HasBowl)
            : base(ID, price, isAvailable, brand, Capacity, CableLength, Affixes)
        {
            this.HasBowl = HasBowl;
        }

        public bool HasBowl
        { get; private set; }

        public override string ToString()
        {
            return base.ToString() + $"\nHas a bowl: {this.HasBowl}";
        }
    }
}
