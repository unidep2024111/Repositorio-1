using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO1
{
    public partial class Form1 : Form
    {
        int resultado = 0 ;
        public Form1()
        {
           
            var num1 = 7;   
            var num2 = 5;
            int resultado = Suma(num1, num2);
        }

        private int Suma(int a, int b)
        {
          int totalsuma = a + b;
          return totalsuma;
                
        }
    }
}
