using System;
using System.ComponentModel.DataAnnotations;

namespace inventory.Models  {
    public class Menu  {
        public int ID  {get; set;}
        public String Name { get; set; }
        public String Description { get; set; }
        public String ImageUrl  {get; set;}
        public double Price  {get; set;}
        public int InStock  {get; set;}
    }    
}