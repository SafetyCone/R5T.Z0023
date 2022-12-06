using System;


namespace R5T.Z0023
{
	public class LibraryDescriptions : ILibraryDescriptions
	{
		#region Infrastructure

	    public static ILibraryDescriptions Instance { get; } = new LibraryDescriptions();

	    private LibraryDescriptions()
	    {
        }

	    #endregion
	}
}