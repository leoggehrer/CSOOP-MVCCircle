using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCCircle.Logic
{
    public class CircleController
    {
		private CircelModel _model = new CircelModel();

		public ICircelModel Model
		{
			get { return _model; }
		}

		public double Radius
		{
			get
			{
				return _model.Radius;
			}
			set
			{
				if (value >= 0 && value <= 500)
				{
					_model.Radius = value;
				}
				else
				{
					throw new MVCException("Der Wert des radius muss zwischen 0 und 500 sein!");
				}
			}
		}
	}
}
