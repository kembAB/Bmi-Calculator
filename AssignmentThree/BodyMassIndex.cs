using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace AssignmentThree
{
    class BodyMassIndex
    {
        private string name;
        private float Height;
        private float weight;
        private float bmi;
       // private const float BMIconstant= 703.0f;
        public BodyMassIndex()
        {
            name = string.Empty;
            Height = 0.0f;
            weight = 0.0f;



        }
        public void SetName(string name)
        {

            if (!string.IsNullOrEmpty(name))
                this.name = name;

        }
        public string GetName()
        {

            if (string.IsNullOrEmpty(name))
                return "no name!";
            else
                return name;
        }



        public void SetHeight(float Height)
        {

            if (Height >= 0.0f)
                this.Height = Height;

        }

        public float GetHeight()
        {

            return Height;


        }

        public void Setweight(float weight)
        {

            if (weight >= 0.0f)
                this.weight = weight;

        }

        public float Getweight()
        {

            return weight;


        }




        public float CalculateBMImetric()
        {
            Height = (Height*Height)/10000f;
            bmi = weight/Height;
            return bmi;
        }

        public float CalculateBMImeUS()
        {

            // float bmione = BMIconstant * weight;
            Height *= Height;
            weight *= 703.0f;
            bmi = weight / Height;
            return bmi;
            //Height *= Height;
            //weight *= 703.0f;
            //    bmi = weight / Height ;
            //return bmi;

        }

        public float weightcatagoryus(float bmi)
        {

            this.bmi = CalculateBMImeUS();
            return this.bmi;
        }
        public float weightcatagoryMetric(float bmi)
        {

            this.bmi = CalculateBMImetric();
            return this.bmi;
        }



    }
}

