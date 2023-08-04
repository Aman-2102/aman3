using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    
        static void Main(string[] args)
        {
            flipcart objcust = new flipcart("hi");
            
            
            objcust.cart();
            objcust.payment();
            objcust.checklist();
            objcust.search_history();
            objcust.stock();
            objcust.search();
        
            Console.ReadKey();
        }
    





    public abstract class myntra

    {
        public abstract void cart();
        public abstract void payment();
        public void search()
        {
            Console.WriteLine("clothes");
        }
        public virtual void checklist()
        {
            Console.WriteLine("shoes");
        }
        
    }
    public class flipcart : myntra,amazon
    {
        public override void cart()
        {
            Console.WriteLine("tshirt");
            
        }
        public override void payment()
        {
            Console.WriteLine("pay by upi");
           
        }
        public override void checklist()
        {
            Console.WriteLine("sandal");
            base.checklist();
        }
        public void search_history()
        {
            Console.WriteLine("bracellete");
        }
        public void stock()
        {
            Console.WriteLine("about to finish");
        }
        
        public  flipcart(string modelName)
        {
            Console.WriteLine($"conversation {modelName}"); 
        }
       public new void search()
        {
            Console.WriteLine("bike");
            base.search();
        }
    }
    interface amazon
    {
        void search_history();
        void stock();
    }

}
