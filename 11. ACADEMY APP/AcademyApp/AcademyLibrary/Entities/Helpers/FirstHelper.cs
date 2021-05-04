using AcademyLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyLibrary.Entities.Helpers
{
    public  class FirstHelper<T> where T:User
    {

        public string GoThroughAList(List<T> items, string userName1) 
        {

            string message = null;
            foreach (T item in items)
            {
                if (item.Username == userName1)
                {
                    Console.WriteLine("Try again!");
                    return message = "Try Again";
                    

                } 
                
            }
            if (message == "Try Again")
                return message;
            else
            return userName1;

        }


        
    }
}
