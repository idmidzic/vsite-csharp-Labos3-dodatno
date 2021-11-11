using System;

namespace C_sharp_vj2
{
	/// <summary>
	/// Summary description for QuadraticEquation.
	/// </summary>
	public class QuadraticEquation
	{
		private double m_a;
		private double m_b;
		private double m_c;

		public QuadraticEquation(){}
		public QuadraticEquation( double a, double b, double c )
		{
			m_a = a;
			m_b = b;
			m_c = c;
		}
		
		public double A
		{
			get
			{ 
				return m_a;
			}
			set
			{
				m_a = value;
			}
		}
		public double B
		{
			get
			{ 
				return m_b;
			}
			set
			{
				m_b = value;
			}
		}
		public double C
		 {
			 get
			 { 
				 return m_c;
			 }
			 set
			 {
				 m_c = value;
			 }
		 }
		public double Y(double x)
		{
			return m_a * x * x + m_b * x + m_c;
		}
		public double Discriminant
		{
			get {return B * B - 4 * A * C; }
		}
		
		/*
		/// <summary>
        /// Vraæa korijenje
        /// </summary>
        public double[] Roots
        {
            get
            {
                if (Discriminant < 0)
                    throw new NotRealRootsException("Korijeni nisu realni");
                double[] results = new double[2];
                results[0] = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                results[1] = (-B - Math.Sqrt(Discriminant)) / (2 * A);
                return results;
            }
        }*/
		/// <summary>
		/// Vraæa korijenje
		/// </summary>
		public Complex[] Roots { 
			get
			{
				Complex r1 = ( -B + Complex.Sqrt( Discriminant )[0]) / ( 2 * A );
				Complex r2 = (-B + Complex.Sqrt(Discriminant)[1]) / ( 2 * A );
				return new Complex[]{r1,r2};
			}
		} 
	}
}
