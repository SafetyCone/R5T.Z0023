using System;

using R5T.T0131;


namespace R5T.Z0023
{
	[ValuesMarker]
	public partial interface ISolutionDescriptions : IValuesMarker
	{
		public string Example => "An example solution description.";
	}
}