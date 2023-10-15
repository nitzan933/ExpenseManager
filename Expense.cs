using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseManager.src
{
    public class Expense
    {
        public int id {  get; set; }
        public bool income { get; set; } = false;
        public string description { get; set; } = "";
        public string category { get; set; } = "";
        public double amount { get; set; } = 0;
        public string date {  get; set; } = DateTime.Now.ToString("dd/MM/yyyy");
        public int[] payments { get; set; } = {1,1};
        public bool continual { get; set; } = false;
        public string comments { get; set; } = "";
    }
}
