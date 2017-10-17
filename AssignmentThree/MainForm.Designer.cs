using System.Windows.Forms;

namespace AssignmentThree
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FuelGroup = new System.Windows.Forms.GroupBox();
            this.txtPreviousReading = new System.Windows.Forms.TextBox();
            this.txtCurrentFuelTanked = new System.Windows.Forms.TextBox();
            this.txtPLitcePerLiter = new System.Windows.Forms.TextBox();
            this.txtCurrentReading = new System.Windows.Forms.TextBox();
            this.btnCalculateFuel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultsGroup = new System.Windows.Forms.GroupBox();
            this.lblkmperliter = new System.Windows.Forms.Label();
            this.lblKmLit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblLitSweMile = new System.Windows.Forms.Label();
            this.lblCostKm = new System.Windows.Forms.Label();
            this.lblLitMile = new System.Windows.Forms.Label();
            this.lblLitKm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbFuel = new System.ComponentModel.BackgroundWorker();
            this.BMIGroup = new System.Windows.Forms.GroupBox();
            this.radUsUnit = new System.Windows.Forms.RadioButton();
            this.radMetric = new System.Windows.Forms.RadioButton();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblweight = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.BMIResultsGroup = new System.Windows.Forms.GroupBox();
            this.lblWeightCatagory = new System.Windows.Forms.Label();
            this.lblYourBMI = new System.Windows.Forms.Label();
            this.lblBMIDescription = new System.Windows.Forms.Label();
            this.lblBMIDisplay = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FuelGroup.SuspendLayout();
            this.ResultsGroup.SuspendLayout();
            this.BMIGroup.SuspendLayout();
            this.BMIResultsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // FuelGroup
            // 
            this.FuelGroup.Controls.Add(this.txtPreviousReading);
            this.FuelGroup.Controls.Add(this.txtCurrentFuelTanked);
            this.FuelGroup.Controls.Add(this.txtPLitcePerLiter);
            this.FuelGroup.Controls.Add(this.txtCurrentReading);
            this.FuelGroup.Controls.Add(this.btnCalculateFuel);
            this.FuelGroup.Controls.Add(this.label4);
            this.FuelGroup.Controls.Add(this.label3);
            this.FuelGroup.Controls.Add(this.label2);
            this.FuelGroup.Controls.Add(this.label1);
            this.FuelGroup.Controls.Add(this.ResultsGroup);
            this.FuelGroup.ForeColor = System.Drawing.Color.Green;
            this.FuelGroup.Location = new System.Drawing.Point(12, 21);
            this.FuelGroup.Name = "FuelGroup";
            this.FuelGroup.Size = new System.Drawing.Size(525, 439);
            this.FuelGroup.TabIndex = 0;
            this.FuelGroup.TabStop = false;
            this.FuelGroup.Text = "Fuel";
            // 
            // txtPreviousReading
            // 
            this.txtPreviousReading.Location = new System.Drawing.Point(247, 42);
            this.txtPreviousReading.Name = "txtPreviousReading";
            this.txtPreviousReading.Size = new System.Drawing.Size(210, 20);
            this.txtPreviousReading.TabIndex = 14;
            this.txtPreviousReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentFuelTanked
            // 
            this.txtCurrentFuelTanked.Location = new System.Drawing.Point(247, 63);
            this.txtCurrentFuelTanked.Name = "txtCurrentFuelTanked";
            this.txtCurrentFuelTanked.Size = new System.Drawing.Size(210, 20);
            this.txtCurrentFuelTanked.TabIndex = 13;
            this.txtCurrentFuelTanked.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPLitcePerLiter
            // 
            this.txtPLitcePerLiter.Location = new System.Drawing.Point(247, 89);
            this.txtPLitcePerLiter.Name = "txtPLitcePerLiter";
            this.txtPLitcePerLiter.Size = new System.Drawing.Size(210, 20);
            this.txtPLitcePerLiter.TabIndex = 12;
            this.txtPLitcePerLiter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentReading
            // 
            this.txtCurrentReading.Location = new System.Drawing.Point(247, 19);
            this.txtCurrentReading.Name = "txtCurrentReading";
            this.txtCurrentReading.Size = new System.Drawing.Size(210, 20);
            this.txtCurrentReading.TabIndex = 11;
            this.txtCurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculateFuel
            // 
            this.btnCalculateFuel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculateFuel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCalculateFuel.Location = new System.Drawing.Point(102, 142);
            this.btnCalculateFuel.Name = "btnCalculateFuel";
            this.btnCalculateFuel.Size = new System.Drawing.Size(223, 23);
            this.btnCalculateFuel.TabIndex = 9;
            this.btnCalculateFuel.Text = "Calculate";
            this.btnCalculateFuel.UseVisualStyleBackColor = false;
            this.btnCalculateFuel.Click += new System.EventHandler(this.btnCalculateFuel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "price per liter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current amount of fuel tanked(liters)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Previous odometer reading(km)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current odometer reading(km)";
            // 
            // ResultsGroup
            // 
            this.ResultsGroup.Controls.Add(this.lblkmperliter);
            this.ResultsGroup.Controls.Add(this.lblKmLit);
            this.ResultsGroup.Controls.Add(this.label10);
            this.ResultsGroup.Controls.Add(this.lblLitSweMile);
            this.ResultsGroup.Controls.Add(this.lblCostKm);
            this.ResultsGroup.Controls.Add(this.lblLitMile);
            this.ResultsGroup.Controls.Add(this.lblLitKm);
            this.ResultsGroup.Controls.Add(this.label5);
            this.ResultsGroup.Controls.Add(this.label6);
            this.ResultsGroup.Controls.Add(this.label9);
            this.ResultsGroup.Controls.Add(this.label7);
            this.ResultsGroup.Controls.Add(this.label8);
            this.ResultsGroup.Location = new System.Drawing.Point(11, 210);
            this.ResultsGroup.Name = "ResultsGroup";
            this.ResultsGroup.Size = new System.Drawing.Size(454, 206);
            this.ResultsGroup.TabIndex = 10;
            this.ResultsGroup.TabStop = false;
            this.ResultsGroup.Text = "Results";
            // 
            // lblkmperliter
            // 
            this.lblkmperliter.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblkmperliter.AllowDrop = true;
            this.lblkmperliter.AutoSize = true;
            this.lblkmperliter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblkmperliter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblkmperliter.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblkmperliter.Location = new System.Drawing.Point(203, 26);
            this.lblkmperliter.Name = "lblkmperliter";
            this.lblkmperliter.Size = new System.Drawing.Size(43, 15);
            this.lblkmperliter.TabIndex = 16;
            this.lblkmperliter.Text = "label11";
            this.lblkmperliter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblKmLit
            // 
            this.lblKmLit.AutoSize = true;
            this.lblKmLit.Location = new System.Drawing.Point(183, 16);
            this.lblKmLit.Name = "lblKmLit";
            this.lblKmLit.Size = new System.Drawing.Size(0, 13);
            this.lblKmLit.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 14;
            // 
            // lblLitSweMile
            // 
            this.lblLitSweMile.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblLitSweMile.AllowDrop = true;
            this.lblLitSweMile.AutoSize = true;
            this.lblLitSweMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLitSweMile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLitSweMile.Location = new System.Drawing.Point(203, 124);
            this.lblLitSweMile.MinimumSize = new System.Drawing.Size(41, 13);
            this.lblLitSweMile.Name = "lblLitSweMile";
            this.lblLitSweMile.Size = new System.Drawing.Size(45, 15);
            this.lblLitSweMile.TabIndex = 13;
            this.lblLitSweMile.Text = "adaada";
            this.lblLitSweMile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCostKm
            // 
            this.lblCostKm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblCostKm.AllowDrop = true;
            this.lblCostKm.AutoSize = true;
            this.lblCostKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCostKm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCostKm.Location = new System.Drawing.Point(203, 156);
            this.lblCostKm.MinimumSize = new System.Drawing.Size(41, 13);
            this.lblCostKm.Name = "lblCostKm";
            this.lblCostKm.Size = new System.Drawing.Size(45, 15);
            this.lblCostKm.TabIndex = 12;
            this.lblCostKm.Text = "adadad";
            this.lblCostKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLitMile
            // 
            this.lblLitMile.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblLitMile.AllowDrop = true;
            this.lblLitMile.AutoSize = true;
            this.lblLitMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLitMile.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLitMile.Location = new System.Drawing.Point(203, 88);
            this.lblLitMile.MinimumSize = new System.Drawing.Size(41, 13);
            this.lblLitMile.Name = "lblLitMile";
            this.lblLitMile.Size = new System.Drawing.Size(45, 15);
            this.lblLitMile.TabIndex = 11;
            this.lblLitMile.Text = "adadad";
            this.lblLitMile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLitKm
            // 
            this.lblLitKm.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.lblLitKm.AllowDrop = true;
            this.lblLitKm.AutoSize = true;
            this.lblLitKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLitKm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLitKm.Location = new System.Drawing.Point(203, 55);
            this.lblLitKm.MinimumSize = new System.Drawing.Size(41, 13);
            this.lblLitKm.Name = "lblLitKm";
            this.lblLitKm.Size = new System.Drawing.Size(45, 15);
            this.lblLitKm.TabIndex = 10;
            this.lblLitKm.Text = "adadad";
            this.lblLitKm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fuel consumption (km/lit)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fuel consumption (lit/km)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Cost per kilometer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fuel consumption (lit/metric mile)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fuel consumption (lit/Swe mil)";
            // 
            // BMIGroup
            // 
            this.BMIGroup.Controls.Add(this.radUsUnit);
            this.BMIGroup.Controls.Add(this.radMetric);
            this.BMIGroup.Controls.Add(this.txtWeight);
            this.BMIGroup.Controls.Add(this.txtYourName);
            this.BMIGroup.Controls.Add(this.txtHeight);
            this.BMIGroup.Controls.Add(this.lblweight);
            this.BMIGroup.Controls.Add(this.label19);
            this.BMIGroup.Controls.Add(this.btnCalculateBMI);
            this.BMIGroup.Controls.Add(this.lblHeight);
            this.BMIGroup.Controls.Add(this.BMIResultsGroup);
            this.BMIGroup.Location = new System.Drawing.Point(584, 21);
            this.BMIGroup.Name = "BMIGroup";
            this.BMIGroup.Size = new System.Drawing.Size(470, 439);
            this.BMIGroup.TabIndex = 11;
            this.BMIGroup.TabStop = false;
            this.BMIGroup.Text = "BMI";
            // 
            // radUsUnit
            // 
            this.radUsUnit.AutoSize = true;
            this.radUsUnit.Location = new System.Drawing.Point(224, 77);
            this.radUsUnit.Name = "radUsUnit";
            this.radUsUnit.Size = new System.Drawing.Size(99, 17);
            this.radUsUnit.TabIndex = 19;
            this.radUsUnit.Text = "US Unit(lb,inch)";
            this.radUsUnit.UseVisualStyleBackColor = true;
            this.radUsUnit.CheckedChanged += new System.EventHandler(this.radUsUnit_CheckedChanged);
            // 
            // radMetric
            // 
            this.radMetric.AutoSize = true;
            this.radMetric.Checked = true;
            this.radMetric.Location = new System.Drawing.Point(224, 53);
            this.radMetric.Name = "radMetric";
            this.radMetric.Size = new System.Drawing.Size(114, 17);
            this.radMetric.TabIndex = 18;
            this.radMetric.TabStop = true;
            this.radMetric.Text = "Metric Unit (kg,cm)";
            this.radMetric.UseVisualStyleBackColor = true;
            this.radMetric.CheckedChanged += new System.EventHandler(this.radMetric_CheckedChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(96, 77);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 26;
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(93, 22);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(277, 20);
            this.txtYourName.TabIndex = 24;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(96, 53);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 25;
            // 
            // lblweight
            // 
            this.lblweight.AutoSize = true;
            this.lblweight.Location = new System.Drawing.Point(22, 81);
            this.lblweight.Name = "lblweight";
            this.lblweight.Size = new System.Drawing.Size(59, 13);
            this.lblweight.TabIndex = 17;
            this.lblweight.Text = "Weight(kg)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 13);
            this.label19.TabIndex = 16;
            this.label19.Text = "Your name";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateBMI.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCalculateBMI.Location = new System.Drawing.Point(110, 133);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(138, 23);
            this.btnCalculateBMI.TabIndex = 15;
            this.btnCalculateBMI.Text = "Calculate";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 56);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(58, 13);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height(cm)";
            // 
            // BMIResultsGroup
            // 
            this.BMIResultsGroup.Controls.Add(this.lblWeightCatagory);
            this.BMIResultsGroup.Controls.Add(this.lblYourBMI);
            this.BMIResultsGroup.Controls.Add(this.lblBMIDescription);
            this.BMIResultsGroup.Controls.Add(this.lblBMIDisplay);
            this.BMIResultsGroup.Controls.Add(this.label18);
            this.BMIResultsGroup.Controls.Add(this.label17);
            this.BMIResultsGroup.Location = new System.Drawing.Point(41, 200);
            this.BMIResultsGroup.Name = "BMIResultsGroup";
            this.BMIResultsGroup.Size = new System.Drawing.Size(368, 181);
            this.BMIResultsGroup.TabIndex = 11;
            this.BMIResultsGroup.TabStop = false;
            this.BMIResultsGroup.Text = "Resutls for ";
            // 
            // lblWeightCatagory
            // 
            this.lblWeightCatagory.AutoSize = true;
            this.lblWeightCatagory.Location = new System.Drawing.Point(106, 59);
            this.lblWeightCatagory.Name = "lblWeightCatagory";
            this.lblWeightCatagory.Size = new System.Drawing.Size(41, 13);
            this.lblWeightCatagory.TabIndex = 18;
            this.lblWeightCatagory.Text = "label12";
            // 
            // lblYourBMI
            // 
            this.lblYourBMI.AutoSize = true;
            this.lblYourBMI.Location = new System.Drawing.Point(106, 29);
            this.lblYourBMI.Name = "lblYourBMI";
            this.lblYourBMI.Size = new System.Drawing.Size(41, 13);
            this.lblYourBMI.TabIndex = 17;
            this.lblYourBMI.Text = "label11";
            // 
            // lblBMIDescription
            // 
            this.lblBMIDescription.AutoSize = true;
            this.lblBMIDescription.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblBMIDescription.Location = new System.Drawing.Point(52, 115);
            this.lblBMIDescription.Name = "lblBMIDescription";
            this.lblBMIDescription.Size = new System.Drawing.Size(201, 13);
            this.lblBMIDescription.TabIndex = 16;
            this.lblBMIDescription.Text = "NORMAL BMI is between  18.5 and 24.9";
            // 
            // lblBMIDisplay
            // 
            this.lblBMIDisplay.AutoSize = true;
            this.lblBMIDisplay.Location = new System.Drawing.Point(103, 139);
            this.lblBMIDisplay.MaximumSize = new System.Drawing.Size(100, 13);
            this.lblBMIDisplay.MinimumSize = new System.Drawing.Size(60, 13);
            this.lblBMIDisplay.Name = "lblBMIDisplay";
            this.lblBMIDisplay.Size = new System.Drawing.Size(60, 13);
            this.lblBMIDisplay.TabIndex = 15;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "Your BMI";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Weight Catagory";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 593);
            this.Controls.Add(this.BMIGroup);
            this.Controls.Add(this.FuelGroup);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "MainForm";
            this.Text = "Universal Calculator";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FuelGroup.ResumeLayout(false);
            this.FuelGroup.PerformLayout();
            this.ResultsGroup.ResumeLayout(false);
            this.ResultsGroup.PerformLayout();
            this.BMIGroup.ResumeLayout(false);
            this.BMIGroup.PerformLayout();
            this.BMIResultsGroup.ResumeLayout(false);
            this.BMIResultsGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FuelGroup;
        private System.ComponentModel.BackgroundWorker gbFuel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateFuel;
        private System.Windows.Forms.GroupBox ResultsGroup;
        private System.Windows.Forms.GroupBox BMIGroup;
        private System.Windows.Forms.GroupBox BMIResultsGroup;
        private System.Windows.Forms.TextBox txtPreviousReading;
        private System.Windows.Forms.TextBox txtCurrentFuelTanked;
        private System.Windows.Forms.TextBox txtPLitcePerLiter;
        private System.Windows.Forms.TextBox txtCurrentReading;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblLitSweMile;
        private System.Windows.Forms.Label lblCostKm;
        private System.Windows.Forms.Label lblLitMile;
        private System.Windows.Forms.Label lblLitKm;
        private System.Windows.Forms.Label lblweight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblBMIDisplay;
        private Label label10;
        private Label lblKmLit;
        private Label lblkmperliter;
        private Label lblBMIDescription;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private TextBox txtYourName;
        private Label lblWeightCatagory;
        private Label lblYourBMI;
        private RadioButton radUsUnit;
        private RadioButton radMetric;
        private Timer timer1;
    }
}

