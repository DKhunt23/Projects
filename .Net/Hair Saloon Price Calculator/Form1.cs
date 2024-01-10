/*
 * Author: Dipsa Khunt
 * Date: 30 Oct 2022
 * Class: Form1.cs
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// 
/// Authorship: I, Dipsa Khunt, 000870839 certify that this material is my original work.
///             No other person's work has been used without due acknowledgement.     
///             
/// Purpose: Hair Saloon form to add hair dresser their rate, add service and calculate total price 
///          Reset form and Exit functionality
/// </summary>


namespace Lab3B
{
    public partial class Form1 : Form
    {
        //variable for hairdresser rate
        public double hairDresserRate;
        //variable for rate of hairdresser service
        public double serviceRate;
        public Form1()
        {
            InitializeComponent();
            //disabling AddService button at start
            buttonAddService.Enabled = false;
            //disabling Calculate Price button at start
            buttonCalculatePrice.Enabled = false;
            //disabling Reset button at start
            buttonReset.Enabled = false;
            //blank listBox of Charge
            listBoxCharge.SelectionMode = SelectionMode.None;
            //blank listBox of Selection
            listBoxPrice.SelectionMode = SelectionMode.None;
            //blank listBox of Total Price
            listBoxTotalPrice.SelectionMode = SelectionMode.None;
        }

        /// <summary>
        /// enum, rate of all hair dresser
        /// </summary>

        private enum hairDresserName
        {
            JaneSamley = 30,
            PatJohnson = 45,
            RonChambers = 40,
            SuePallon = 50,
            LauraRenkins = 55

        }

        /// <summary>
        /// enum, rate of service of each hair dresser
        /// </summary>
        
        private enum serviceCharge
        {
            Cut = 30,
            Wash_blowdry_style = 20,
            Colour = 40,
            Highlights = 50,
            Extension = 200,
            Up_do = 60

        }

        /// <summary>
        /// add hairdresser of choice
        /// </summary>
        private void addDresser()
        {
            // storing index of selected item
            int comboboxindex = (int)comboBoxHairDresser.SelectedIndex;

            
            if (comboboxindex == 0)
            {
                hairDresserRate = (double)hairDresserName.JaneSamley;
            }
            else if (comboboxindex == 1)
            {
                hairDresserRate = (double)hairDresserName.PatJohnson;
            }
            else if (comboboxindex == 2)
            {
                hairDresserRate = (double)hairDresserName.RonChambers;
            }
            else if (comboboxindex == 3)
            {
                hairDresserRate = (double)hairDresserName.SuePallon;
            }
            else if (comboboxindex == 4)
            {
                hairDresserRate = (double)hairDresserName.LauraRenkins;
            }

            //rate of hair dresser appears in listbox of Charged items
            if (!listBoxCharge.Items.Contains((string)comboBoxHairDresser.SelectedItem))
            {
                listBoxCharge.Items.Add((string)comboBoxHairDresser.SelectedItem);
                listBoxPrice.Items.Add(hairDresserRate);
            }
        }

        /// <summary>
        /// add hairdresser of choice
        /// </summary>
        private void addHairService()
        {
            //for adding name of service 
            string service = "";

            int selectserviceindex = listBoxService.SelectedIndex;
            if (selectserviceindex == 0)
            {
                serviceRate = (double)serviceCharge.Cut;
            }
            if (selectserviceindex == 1)
            {
                serviceRate = (double)serviceCharge.Wash_blowdry_style;
            }
            if (selectserviceindex == 2)
            {
                serviceRate = (double)serviceCharge.Colour;
            }
            if (selectserviceindex == 3)
            {
                serviceRate = (double)serviceCharge.Highlights;
            }
            if (selectserviceindex == 4)
            {
                serviceRate = (double)serviceCharge.Extension;
            }
            if (selectserviceindex == 5)
            {
                serviceRate = (double)serviceCharge.Up_do;
            }

            
            service = listBoxService.SelectedItem.ToString();

            // adding only if service are not already added
            if (!listBoxCharge.Items.Contains(service))
            {
                listBoxCharge.Items.Add(service);
                listBoxPrice.Items.Add(serviceRate);
            }
        }

        /// <summary>
        /// onclick button AddService add hairDresser, service, enable calculate price, disable combobox of hairdesser
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddService_Click(object sender, EventArgs e)
        {
            addDresser();
            addHairService();
            buttonCalculatePrice.Enabled = true;
            comboBoxHairDresser.Enabled = false;
            
        }

        /// <summary>
        /// onClick Calculate Total Price, add price of all items in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculatePrice_Click(object sender, EventArgs e)
        {
            double totalprice = 0;
            for (int x = 0; x < listBoxPrice.Items.Count; x++)
            {
                totalprice += (double)listBoxPrice.Items[x];
            }
            if (!listBoxTotalPrice.Items.Contains(totalprice))
            {
                listBoxTotalPrice.Items.Clear();
                listBoxTotalPrice.Items.Add($"{totalprice:C}");
            }
        }

        /// <summary>
        /// Reset form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxHairDresser.Enabled = true;
            buttonAddService.Enabled = false;
            buttonCalculatePrice.Enabled = false;
            buttonReset.Enabled = false;
            comboBoxHairDresser.SelectedIndex = 0;
            listBoxService.SelectedIndex = 0;
            listBoxTotalPrice.Items.Clear();
            listBoxCharge.Items.Clear();
            listBoxPrice.Items.Clear();

        }

        

        /// <summary>
        /// enabling Addservice and reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxService_MouseClick(object sender, MouseEventArgs e)
        {
            buttonAddService.Enabled = true;
            buttonReset.Enabled = true;
        }
        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
