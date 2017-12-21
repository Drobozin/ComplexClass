using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    class ComplexClass
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public double Abs
        {
            get
            {
                return Math.Sqrt(Re * Re + Im * Im);
            }
        }
        public double Arg
        {
            get
            {
                return Math.Atan2(Im, Re) * 100 / Math.PI;
            }
        }
        public ComplexClass(double Re, double Im)
        {
            this.Re = Re;
            this.Im = Im;
        }
        public override string ToString()
        {
            if (Re != 0 && Im == 1) { return (String.Format($"{Re} + i")); }
            else if (Re != 0 && Im == -1) { return (String.Format($"{Re} -i")); }
            else if (Re == 0 && Im == 1) { return (String.Format("i")); }
            else if (Re != 0 && Im == 0) { return (String.Format($"{Re}")); }
            else if (Re != 0 && Im <= -2) { return (String.Format("{0} - {1}i", Re, Math.Abs(Im))); }
            else if (Re == 0 && Im == 0) { return (String.Format("0")); }
            else if (Re == 0 && Im == -1) { return (String.Format("-{0}i", Math.Abs(Im))); }
            else if (Re == 0 && Im > 0) { return (String.Format("{0}i", Im)); }
            else if (Re == 0 && Im == -1) { return (String.Format("-{0}i", Math.Abs(Im))); }
            else if (Re == 0 && Im == -2) { return (String.Format("- {0}i", Math.Abs(Im))); }
            else if (Im < 0) { return (String.Format("{0} - {1}i", Re, Math.Abs(Im))); }
            else if (Re == 0 && Im < 0) { return (String.Format("{0}i", Math.Abs(Im))); }
            else return (String.Format($"{Re} + {Im}i"));
        }
        public bool Equals(ComplexClass other)
        {
            if (!(!(this is null)) || !(other is ComplexClass))
                return false;
            else
                return Re.Equals(other.Re) && Im.Equals(other.Im);
        }
        public override bool Equals(object obj)
        {
            try
            {
                return Equals((ComplexClass)obj);
            }
            catch
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            var hash = 49;
            hash = hash * 15 + Re.GetHashCode();
            hash = hash * 15 + Im.GetHashCode();
            return hash;
        }
        public static ComplexClass GetComplex(double mod, double arg)
        {
            double new_Re = mod * Math.Cos(arg);
            double new_Im = mod * Math.Sin(arg);
            return new ComplexClass(new_Re, new_Im);
        }
        public static ComplexClass operator +(ComplexClass complex1, ComplexClass complex2) => new ComplexClass(complex1.Re + complex2.Re, complex1.Im + complex2.Im);
        public static ComplexClass operator *(ComplexClass complex1, ComplexClass complex2) => new ComplexClass(complex1.Re * complex2.Re, complex1.Im * complex2.Im);
        public static ComplexClass operator -(ComplexClass complex1, ComplexClass complex2) => new ComplexClass(complex1.Re - complex2.Re, complex1.Im - complex2.Im);
        public static ComplexClass operator /(ComplexClass complex1, ComplexClass complex2) => new ComplexClass(complex1.Re / complex2.Re, complex1.Im / complex2.Im);
  
        public static bool operator ==(ComplexClass complex1, ComplexClass complex2)
        {
            if (!(complex1 is ComplexClass) || !(complex2 is ComplexClass))
                return false;
            else
                return complex1.Equals(complex2);
        }
        public static bool operator !=(ComplexClass complex1, ComplexClass complex2)
        {
            return !(complex1 == complex2);
        }

       
    }
}
