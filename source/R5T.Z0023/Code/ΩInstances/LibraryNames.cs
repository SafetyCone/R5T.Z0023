using System;


namespace R5T.Z0023
{
	public class LibraryNames : ILibraryNames
	{
		#region Infrastructure

	    public static ILibraryNames Instance { get; } = new LibraryNames();

	    private LibraryNames()
	    {
        }

	    #endregion
	}
}