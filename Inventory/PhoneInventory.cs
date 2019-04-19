﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class PhoneInventory
    {
        public string id;
        public string model;
        public string capacity;
        public string networks;
        public string quantity;
        public string price;
        public string suppliers;
        public string buyers;

        public PhoneInventory(string id, string model, string capacity, string networks, string quantity, string price, string suppliers, string buyers)
        {
            this.id = id;
            this.model = model;
            this.capacity = capacity;
            this.networks = networks;
            this.quantity = quantity;
            this.price = price;
            this.suppliers = suppliers;
            this.buyers = buyers;
        }

        public string sModel { get; set; }
        public string memory { get; set; }
        public string network { get; set; }
        public string sQuantity { get; set; }
        public string dateTimePicker { get; set; }
        public string sPrice { get; set; }//double
        public string supplier { get; set; }
        public string buyer { get; set; }
        public string prodId { get; set; }

    public string ToString()
        {
            string newString = this.id + "  " + this.model + "          " + this.capacity + "          " + networks + "          " + quantity + "          " + price + "      " + suppliers + "     " + buyers;
                return newString;
        }

        
       

        

    }
    
}

