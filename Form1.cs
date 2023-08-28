using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructureApp
{
   
    public partial class Form1 : Form
    {
        Stack<PlatesType> stackList = new Stack<PlatesType>();
        public Form1()
        {
            InitializeComponent();
            stackUpThePlates();
        }
        private void stackUpThePlates()
        {


            try
            {
                PlatesType pt1 = new PlatesType()
                {
                    plateTypeName = "Plastic Plates",
                    number = 10
                };
                PlatesType pt2 = new PlatesType()
                {
                    plateTypeName = "Breakeable Plates",
                    number = 15
                };
                stackList.Push(pt1);
                stackList.Push(pt2);

                lstBoxStack1.Items.Add(pt1.plateTypeName + " " + pt1.number);
                lstBoxStack1.Items.Add(pt2.plateTypeName + " " + pt2.number);
            }
            catch (Exception ex)
            {

              
            }



        }

        private void bttnDown_Click(object sender, EventArgs e)
        {
         
            while (stackList.Count>0)
            {
                PlatesType platesType = stackList.Pop();

                lstBoxStack2.Items.Add(platesType.plateTypeName + " " + platesType.number);
            }
            lstBoxStack1.Items.Clear();
           
        }

        private void bttnUp_Click(object sender, EventArgs e)
        {
            stackUpThePlates();
            lstBoxStack2.Items.Clear();
        }
    }
    public class PlatesType
    {
        public string plateTypeName { get; set; }
        public int number { get; set; }

    }
}
