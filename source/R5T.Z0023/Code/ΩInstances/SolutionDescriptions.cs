using System;


namespace R5T.Z0023
{
	public class SolutionDescriptions : ISolutionDescriptions
	{
		#region Infrastructure

	    public static ISolutionDescriptions Instance { get; } = new SolutionDescriptions();

	    private SolutionDescriptions()
	    {
        }

	    #endregion
	}
}