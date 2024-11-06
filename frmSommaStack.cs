using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sommaStack
{
    public partial class frmSommaStack : Form
    {
        Stack<double> stack = new Stack<double>();
        public frmSommaStack()
        {
            InitializeComponent();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            double number;
            if (double.TryParse(txtNumero.Text,out number))
            {
                stack.Push(number);
                visualizzaStack(stack);
                visualizzaSommaTotale(stack);
            } else MessageBox.Show("numero non valodo");
                    
        }

        private void visualizzaSommaTotale(Stack<double> stack)
        {
            double tot = 0;
            foreach(double n in stack)
            {
                tot+= n;
            }
            lblTotale.Text = tot.ToString();
        }

        private void visualizzaStack(Stack<double> stack)
        {
            if(stack != null)
            {
                lstStack.Items.Clear();
                foreach (double n in stack) lstStack.Items.Add(n.ToString());
            }
        }

        private void btnIndietro_Click(object sender, EventArgs e)
        {
            if(stack!= null &&stack.Count>0)
            {
                double minus=stack.Pop();

                visualizzaStack(stack);
                visualizzaSommaTotale(stack);
            }
        }
    }
}
