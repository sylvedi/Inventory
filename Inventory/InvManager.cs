using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    class InvManager
    {
        //product list
        private List<PhoneInventory> items;

        //constructor
        public InvManager()
        {
            //initialize the attributes
            items = new List<PhoneInventory>( );

            //put some items in the manager for testing
            PhoneInventory item = new PhoneInventory("1", "s10", "65", "AT&T", "2", "300", "Samsung", "consumer");
            items.Add(item);
            item = new PhoneInventory("3", "q10", "32", "AT&T", "12", "200", "Blackberry", "consumer");
            items.Add(item);
            item = new PhoneInventory("2", "s6", "120", "AT&T", "5", "500", "Iphone", "consumer");
            items.Add(item);

        }
        //make an array of the items in the manager
        public PhoneInventory[] getItemArray()
        {
            int index = 0;
            PhoneInventory[] itemArr = new PhoneInventory[items.Count];
            foreach(PhoneInventory item in items )
            {
                PhoneInventory i = item;
                itemArr[index++] = i;
            }
            return itemArr;
        }
        
        //
        public void addItem(PhoneInventory item)
        {

            items.Add(item);
        }

        public void removeItem(PhoneInventory item)
        {
            items.Remove(item);
        }
        public PhoneInventory findByID(string id)
        {
            PhoneInventory result = null;
            for(int i = 0; i<items.Count(); i++)
            {
                //does this product have the same id as param id?
                if (items[i].prodId == id)
                    result = items[i];
            }

            return result;
        }
    }
}
