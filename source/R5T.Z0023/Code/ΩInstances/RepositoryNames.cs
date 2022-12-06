using System;


namespace R5T.Z0023
{
	public class RepositoryNames : IRepositoryNames
	{
		#region Infrastructure

	    public static IRepositoryNames Instance { get; } = new RepositoryNames();

	    private RepositoryNames()
	    {
        }

	    #endregion
	}
}