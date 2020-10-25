using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestPart3Question2
{
    class Rational
    {
        public int Mone { get; set; }
        public int Mehane { get; set; }
        public Rational(int mone, int mehane)
        {
            Mone = mone;
            if (mehane < 0)
            {
                Mehane = Math.Abs(mehane);
            }
            else
                Mehane = mehane;
        }
        public static double TurnToRational(Rational r1)
        {
            double d = r1.Mone / r1.Mehane;
            return d;
        }
        public static bool operator >(Rational r1,Rational r2)
        {
            double ratio1 = TurnToRational(r1);
            double ratio2 = TurnToRational(r2);
            return ratio1 > ratio2;
        }
        public static bool operator <(Rational r1, Rational r2)
        {
            double ratio1 = TurnToRational(r1);
            double ratio2 = TurnToRational(r2);
            return ratio1 < ratio2;
        }
        public static bool operator ==(Rational r1, Rational r2)
        {
            if (r1 == null && r2 == null)
                return true;
            if (r1 == null || r2 == null)
                return false;
            return r1 == r2;
        }
        public static bool operator !=(Rational r1, Rational r2)
        { 
            return !(r1== r2);
        }
        public static Rational operator +(Rational r1 , Rational r2)
        {
            Rational res = new Rational(r1.Mone + r2.Mone, r1.Mehane + r2.Mehane);
            return res;
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            Rational res = new Rational(Math.Abs(r1.Mone - r2.Mone),Math.Abs(r1.Mehane - r2.Mehane));
            return res;
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            Rational res = new Rational(r1.Mone * r2.Mone, r1.Mehane * r2.Mehane);
            return res;
        }
        public int getNumerator(Rational r1)
        {
            return r1.Mone;
        }
        public int getDenominator(Rational r1)
        {
            return r1.Mehane;
        }
        public override bool Equals(object obj)
        {
            return obj is Rational rational &&
                   Mone == rational.Mone &&
                   Mehane == rational.Mehane;
        }
        public override int GetHashCode()
        {
            int hashCode = -1129719267;
            hashCode = hashCode * -1521134295 + Mone.GetHashCode();
            hashCode = hashCode * -1521134295 + Mehane.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return $"{Mone}/{Mehane}";
        }
    }
}
