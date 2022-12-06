using System;

using R5T.T0131;


namespace R5T.Z0023
{
	[ValuesMarker]
	public partial interface ILibraryDescriptions : IValuesMarker
	{
		public string Example => "Example library description.";
	}
}