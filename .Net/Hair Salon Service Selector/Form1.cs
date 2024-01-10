using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.            
/// </summary>
namespace Lab2B
{


    public partial class Form1 : Form
    {
        private int hair_Dresser_Price; // hairdresser price
        private int services_Price; // services price
        private int client_Type; // client type discount
        private int client_Visit; // client visits discount
        private string clientVisits; // to get client visit from form

        /// <summary>
        ///  to set hair dresser price         
        /// </summary>
        private enum Hair_Dresser_Price
        {
            Jane = 30,
            Pat = 45,
            Ron = 40,
            Sue = 50,
            Laurie = 55
        }
        
        /// <summary>
        /// to set client type          
        /// </summary>
        private enum Client_type
        {
            Adult = 0,
            Child = 10,
            Student = 5,
            Senior = 15
        }
        /// <summary>
        ///to set client visit         
        /// </summary>
        private enum Client_Visit
        {
            oneto3 = 0,
            fourto8 = 5,
            nineto13 = 10,
            fourteenplus = 15
        }
        /// <summary>
        /// to set  services price         
        /// </summary>
        private enum Services
        {
            Cut = 30,
            Colour = 40,
            Highlights = 50,
            Extension = 200

        }

        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///   to set hairdresser price       
        /// </summary>
        private void hairdresser()
        {
            if (radioButtonSamley.Checked == true)
            {
                hair_Dresser_Price = (int)Hair_Dresser_Price.Jane;
            }
            else if (radioButtonJohnson.Checked == true)
            {
                hair_Dresser_Price = (int)Hair_Dresser_Price.Pat;
            }
            else if (radioButtonChambers.Checked == true)
            {
                hair_Dresser_Price = (int)Hair_Dresser_Price.Ron;
            }
            else if (radioButtonPallon.Checked == true)
            {
                hair_Dresser_Price = (int)Hair_Dresser_Price.Sue;
            }
            else if (radioButtonRenkins.Checked == true)
            {
                hair_Dresser_Price = (int)Hair_Dresser_Price.Laurie;
            }
        }

        /// <summary>
        ///   to set client visits        
        /// </summary>
        private void clientvisits()
        {
            if (int.Parse(clientVisits) <= 3 && int.Parse(clientVisits) >= 1)
            {
                client_Visit = (int)Client_Visit.oneto3;
            }
            else if (int.Parse(clientVisits) >= 4 && int.Parse(clientVisits) <= 8)
            {
                client_Visit = (int)Client_Visit.fourto8;
            }
            else if (int.Parse(clientVisits) >= 9 && int.Parse(clientVisits) <= 13)
            {
                client_Visit = (int)Client_Visit.nineto13;
            }
            else if (int.Parse(clientVisits) >= 14)
            {
                client_Visit = (int)Client_Visit.fourteenplus;
            }
        }

        /// <summary>
        ///   to set services price        
        /// </summary>
        private void services()
        {
            if (checkBoxCut.Checked == true)
            {
                services_Price += (int)Services.Cut;
            }
            if (checkBoxColour.Checked == true)
            {
                services_Price += (int)Services.Colour;
            }
            if (checkBoxHighlights.Checked == true)
            {
                services_Price += (int)Services.Highlights;
            }
            if (checkBoxExtensions.Checked == true)
            {
                services_Price += (int)Services.Extension;
            }
        }

        /// <summary>
        ///   to set client type      
        /// </summary>
        private void clienttype()
        {
            if (radioButtonAdult.Checked == true)
            {
                client_Type = (int)Client_type.Adult;

            }
            else if (radioButtonChildUnder12.Checked == true)
            {
                client_Type = (int)Client_type.Child;

            }
            else if (radioButtonStudent.Checked == true)
            {
                client_Type = (int)Client_type.Student;

            }
            else if (radioButtonSenior.Checked == true)
            {
                client_Type = (int)Client_type.Senior;
            }
        }

        /// <summary>
        ///   Setting to default values         
        /// </summary>
        private void clear()
        {
            hair_Dresser_Price = 0;
            services_Price = 0;
            client_Type = 0;
            client_Visit = 0;
            labelTotalPrice.Text = "Total Price: ";
        }

        /// <summary>
        ///   to calculate total amount        
        /// </summary>

        private void button1_Click(object sender, EventArgs e)
        {
            clear(); 
            clientVisits = textBoxClientVisits.Text; // getting client visits
            if (int.Parse(clientVisits) > 0) // if client visit is more than 0 
            {
                hairdresser();
                services();
                int sum = hair_Dresser_Price + services_Price;
                clienttype();
                clientvisits();
                int discountpercent = client_Type + client_Visit;
                int discount = discountpercent * sum / 100;

                int total = sum - discount;
                labelTotalPrice.Text = "Total Price: " + total.ToString();
            }
            else
            {
                MessageBox.Show("Client visit can not be 0 or Negative");
                textBoxClientVisits.Text = "1";
                clear();
            }
        }

        /// <summary>
        ///   Clear all fields and set to default values.         
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            radioButtonSamley.Checked = true;
            radioButtonJohnson.Checked = false;
            radioButtonChambers.Checked = false;
            radioButtonPallon.Checked = false;
            radioButtonRenkins.Checked = false;
            radioButtonAdult.Checked = true;
            radioButtonChildUnder12.Checked = false;
            radioButtonStudent.Checked = false;
            radioButtonSenior.Checked = false;
            textBoxClientVisits.Text = "1";
            checkBoxCut.Checked = true;
            checkBoxColour.Checked = false;
            checkBoxHighlights.Checked = false;
            checkBoxExtensions.Checked = false;
            labelTotalPrice.Text = "Total Price: ";
        }

        /// <summary>
        ///   closes the application         
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
