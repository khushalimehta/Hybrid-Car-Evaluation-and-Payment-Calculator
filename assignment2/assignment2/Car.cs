using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Car
    {
            private static double city_miles;
            private static double highway_miles;
            private static double[] avg_gas = new double[10];
            public string Make { get; set; }
            public string Model { get; set; }
            private double intial_pr;
            private double cpg;
            private double hpg;

            public Car(string make, string model, double initial_pr, double cpg, double hpg)
            {
                this.Make = make;
                this.Model = model;
                this.Initialpr = initial_pr;
                this.CPG = cpg;
                this.HPG = hpg;
            }
            public static double Citymiles
            {
                get
                {
                    return city_miles;
                }
                set
                {
                    if (value > 0)
                    {
                        city_miles = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("City Miles nust be greater than 0.");
                    }
                }
            }
            public static double Highwaymiles
            {
                get
                {
                    return highway_miles;
                }
                set
                {
                    if (value > 0)
                    {
                        highway_miles = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Highway Miles must be greater than 0.");
                    }
                }
            }
            public static double[] Avggas
            {
                get
                {
                    return avg_gas;
                }
                set
                {
                    avg_gas = value;
                }
            }
            public double Initialpr
            {
                get
                {
                    return intial_pr;
                }
                set
                {
                    if (value > 0)
                    {
                        intial_pr = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Initial Price must be greater than 0.");
                    }
                }
            }
            public double CPG
            {
                get
                {
                    return cpg;
                }
                set
                {
                    if (value > 0)
                    {
                        cpg = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("City miles per gallon must be greater than 0.");
                    }
                }
            }
            public double HPG
            {
                get
                {
                    return hpg;
                }
                set
                {
                    if(value > 0)
                    {
                        hpg = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Highway miles per gallon must be greater than 0.");
                    }
                   
                }
            }
            public override string ToString()
            {
                return (String.Format("{0}:{1}:{2}:{3}:{4}\n", Make, Model, Initialpr, CPG, HPG));
            }


        }
    }

