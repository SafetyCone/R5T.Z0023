using System;


namespace R5T.Z0023
{
	public class EndeavorDescriptions : IEndeavorDescriptions
	{
		#region Infrastructure

	    public static IEndeavorDescriptions Instance { get; } = new EndeavorDescriptions();

	    private EndeavorDescriptions()
	    {
        }

	    #endregion
	}
}