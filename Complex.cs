using System;

namespace C_sharp_vj2
{
	/// <summary>
	/// Summary description for Complex.
	/// </summary>
	public struct Complex
	{
		private double m_real;
		private double m_imaginary;
		
		public Complex(double real, double imaginary)
		{
			m_real = real;
 		    m_imaginary = imaginary;
		}
		public Complex(double real )
		{
			m_real = real;
			m_imaginary = 0;
		}
		public static implicit operator Complex(double number)// implicitna pretvorba s desne strane double broj i pretvara u complexni
		{
			return new Complex(number);
		}
		public static Complex[] Sqrt(double number)
		{
			if (number >= 0)
			{
				Complex c1 = new Complex (Math.Sqrt(number));
				Complex c2 = new Complex (-Math.Sqrt(number)); 
				return new Complex[]{c1,c2};
			}
			else
			{
				Complex c1 = new Complex (0,Math.Sqrt(-number));
				Complex c2 = new Complex (0,-Math.Sqrt(-number)); 
				return new Complex[]{c1,c2};
			}
		}
		public double Re
		{
			get{ return m_real; }
			set { m_real = value; }
		}
		public double Im
		{
			get{ return m_imaginary; }
			set { m_imaginary = value; }
		}
		
		public static Complex operator+ (Complex c1, Complex c2)
		{
			return new Complex(c1.Re + c2.Re, c1.Im + c2.Im);
		}
		public static Complex operator- (Complex c1, Complex c2)
		{
			return new Complex(c1.Re - c2.Re, c1.Im - c2.Im);
		}
		public static Complex operator* (Complex c1, Complex c2)
		{
			return new Complex(c1.Re * c2.Re - c2.Im * c1.Im, c1.Re * c2.Im - c2.Re * c1.Im );
		}
		public static Complex operator/ (Complex c1, Complex c2)
		{
			double naz = c2.Re * c2.Re + c2.Im * c2.Im;
			double re = (c1.Re * c2.Re + c1.Im * c2.Im) / naz;
			double im = (c1.Im * c2.Re - c1.Re * c2.Im) / naz;
			return new Complex( re, im);
		}
		public override string ToString()
		{
			 return String.Format("{0} + {1}i", Re,Im);
		}

	}
}
