using System;


namespace R5T.Z0023
{
	public class SolutionNames : ISolutionNames
	{
		#region Infrastructure

	    public static ISolutionNames Instance { get; } = new SolutionNames();

	    private SolutionNames()
	    {
        }

	    #endregion
	}
}