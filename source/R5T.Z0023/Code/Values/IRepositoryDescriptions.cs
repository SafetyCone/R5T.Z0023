using System;

using R5T.T0131;


namespace R5T.Z0023
{
	[ValuesMarker]
	public partial interface IRepositoryDescriptions : IValuesMarker
	{
		public string Example => "An example repository description.";
	}
}