using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentThree
{
    //user interface 
    public partial class MainForm : Form
    {
        //object creation 
        private BodyMassIndex bmiCalc = new BodyMassIndex();
        private FuelCalculator carMilage = new FuelCalculator();
        private string name = string.Empty;
        //private float weightca;
        //private float weightCatagoryval;
        //private double weightcatagory;
        //double weightca;
        private float catagory;
        private float catagoryval;

        public MainForm()
        {

            //these are done by visual studio
            InitializeComponent();
            //the following are done by the programmer
            InitializeGUI();
            InitializeFUELgui();
            InitializeBMIgui();
        }

        public void InitializeBMIgui()
        {
            //below initializing BMI textboxes as empty 

            txtYourName.Text = String.Empty;
            txtHeight.Text = String.Empty;
            txtWeight.Text = String.Empty;
            //below initializing BMI(Results ) lables as empty
            lblYourBMI.Text = String.Empty;
            lblWeightCatagory.Text = String.Empty;
            //initializing radio boxes
            radMetric.Checked = true;
            radUsUnit.Checked = false;
            lblHeight.Text = string.Empty;
            lblweight.Text = string.Empty;
            lblHeight.Text = "height(cm)";
            lblweight.Text = "Weight(kg)";
        }

        public void InitializeFUELgui()
        {

            //below initializing BMI textboxes as empty 
            //below initializing FUEL text boxes  empty
            txtCurrentReading.Text = string.Empty;
            txtCurrentFuelTanked.Text = String.Empty;
            txtPreviousReading.Text = String.Empty;
            txtPLitcePerLiter.Text = String.Empty;

            //below initializing Fuel Results labels empty 


            lblkmperliter.Text = String.Empty;
            lblLitKm.Text = String.Empty;
            lblLitMile.Text = String.Empty;
            lblLitSweMile.Text = String.Empty;
            lblCostKm.Text = String.Empty;
        }

        public void InitializeGUI()
        {
            //FuelGroup.Controls.Add(ResultsGroup);


        }

        private bool ReadInputFuel()
        {
            double fuelcurrent = 0.0;
            double fuelPrevious = 0.0;
            double fueltanked = 0.0;
            double fuelperliter = 0.0;
            bool ok;


            //cheking if the user entered a valid fuel data

            ok = double.TryParse(txtCurrentReading.Text,
                NumberStyles.Number, NumberFormatInfo.InvariantInfo,
                out fuelcurrent);

            ok = ok &&
                 double.TryParse(txtPreviousReading.Text,
                     NumberStyles.Number,
                     NumberFormatInfo.InvariantInfo,
                     out fuelPrevious);

            ok = ok &&
                 double.TryParse(txtCurrentFuelTanked.Text, NumberStyles.Number,
                     NumberFormatInfo.InvariantInfo,
                     out fueltanked);


            ok = ok && double.TryParse(txtPLitcePerLiter.Text,
                     NumberStyles.Number, NumberFormatInfo.InvariantInfo,
                     out fuelperliter);

            if (ok)
            {
                carMilage.setfuelcurrent(fuelcurrent);
                carMilage.setfuelPrevious(fuelPrevious);
                carMilage.setfueltanked(fueltanked);
                carMilage.setfuelperliter(fuelperliter);

            }

            return ok;

        }

        private void UpdateFuelGUI()
        {

            lblLitKm.Text = (carMilage.CalculateLitPerKm()).ToString("0.00", CultureInfo.InvariantCulture);
            lblkmperliter.Text = ((carMilage.CalculateKmPerLit())).ToString("0.00", CultureInfo.InvariantCulture);
            lblLitMile.Text = (carMilage.CalculatelitPerMetricMile()).ToString("0.00", CultureInfo.InvariantCulture);
            lblLitSweMile.Text = (carMilage.CalculateSwedishMile()).ToString("0.00", CultureInfo.InvariantCulture);
            lblCostKm.Text = (carMilage.CalculateCostPerKm()).ToString("0.00", CultureInfo.InvariantCulture);



        }

        private void UpdateBMI()
        {

            BMIResultsGroup.Text = string.Empty;
            BMIResultsGroup.Text = "Results For : " + bmiCalc.GetName();

            if (radMetric.Checked)
            {
                lblYourBMI.Text = bmiCalc.CalculateBMImetric().ToString("0.00", CultureInfo.InvariantCulture);
                WeightcatagoryMetric();
            }
            else if (radUsUnit.Checked)
            {

                lblYourBMI.Text = bmiCalc.CalculateBMImeUS().ToString("0.00", CultureInfo.InvariantCulture);
                Weightcatagoryus();




            }
        }

        private bool RedaInputBMI()
        {


            string name = txtYourName.Text.Trim();
            float Height = 0.0f;
            float weight = 0.0f;
            bool ok = !string.IsNullOrEmpty(name) || string.IsNullOrEmpty(name);


            //cheking if the user entered a valid fuel data

            ok = ok && (radUsUnit.Checked || radMetric.Checked);


            ok = ok && float.TryParse(txtHeight.Text,
                     NumberStyles.Number, NumberFormatInfo.InvariantInfo,
                     out Height);

            ok = ok &&
                 float.TryParse(txtWeight.Text,
                     NumberStyles.Number,
                     NumberFormatInfo.InvariantInfo,
                     out weight);

            if (ok)
            {

                bmiCalc.SetName(name);

                bmiCalc.SetHeight(Height);
                bmiCalc.Setweight(weight);

            }

            return ok;
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {

            bool successFuelEntry = RedaInputBMI();
            if (successFuelEntry == true)
            {
                UpdateBMI();



            }
            else
            {
                MessageBox.Show("Invalid input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InitializeBMIgui();
            }
        }

        private void btnCalculateFuel_Click(object sender, EventArgs e)
        {
            // showing the result
            bool successFuelEntry = ReadInputFuel();
            if (successFuelEntry == true)
            {
                UpdateFuelGUI();
            }
            else
            {

                MessageBox.Show("Invalid input ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                InitializeFUELgui();

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            radMetric.Checked = true;

        }

        public void radMetric_CheckedChanged(object sender, EventArgs e)
        {
            //change the text of the lables as the radmetric  checked 
            lblHeight.Text = string.Empty;
            ;
            lblweight.Text = string.Empty;
            ;
            lblHeight.Text = "height(cm)";
            lblweight.Text = "Weight(kg)";


        }

        private void radUsUnit_CheckedChanged(object sender, EventArgs e)
        {
            //change the text of the lables as the radusunit  checked 
            lblHeight.Text = string.Empty;
            lblweight.Text = string.Empty;
            lblHeight.Text = "height(inch)";
            lblweight.Text = "Weight(lb)";

        }

        public void WeightcatagoryMetric()
        {
            catagory=bmiCalc.weightcatagoryMetric(catagoryval);
            //decide the weight catagory of the user
            //bool valid = float.TryParse(lblYourBMI.Text, out catagory);
            
                if (catagory < 18.5f)
                {
                    lblWeightCatagory.Text = "Underweight";
                }
                else if (catagory >= 18.5f && catagory <= 24.9f)
                {
                    lblWeightCatagory.Text = "Normal Weight";
                }

                else if (catagory >= 25.0f && catagory <= 29.9f)
                {
                    lblWeightCatagory.Text = "Overweight";
                }
                else if (catagory >= 30.0f && catagory <= 34.9f)
                {
                    lblWeightCatagory.Text = "Obesity class I";
                }
                else if (catagory >= 35.0f && catagory <= 39.9f)
                {
                    lblWeightCatagory.Text = " Obesity class II";
                }
                else if (catagory >= 35.0f && catagory <= 39.9f)

                {
                    lblWeightCatagory.Text = "Obesity class III";
                }


            
        
        }

        public void Weightcatagoryus()
        {
            catagory=bmiCalc.weightcatagoryus(catagoryval);
            //decide the weight catagory of the user
            //bool valid = float.TryParse(lblYourBMI.Text, out catagory);

            if (catagory < 18.5f)
            {
                lblWeightCatagory.Text = "Underweight";
            }
            else if (catagory >= 18.5f && catagory <= 24.9f)
            {
                lblWeightCatagory.Text = "Normal Weight";
            }

            else if (catagory >= 25.0f && catagory <= 29.9f)
            {
                lblWeightCatagory.Text = "Overweight";
            }
            else if (catagory >= 30.0f && catagory <= 34.9f)
            {
                lblWeightCatagory.Text = "Obesity class I";
            }
            else if (catagory >= 35.0f && catagory <= 39.9f)
            {
                lblWeightCatagory.Text = " Obesity class II";
            }
            else if (catagory >= 35.0f && catagory <= 39.9f)

            {
                lblWeightCatagory.Text = "Obesity class III";
            }


        }

    }
   }