using System;


namespace R5T.Z0023
{
	public class EndeavorNames : IEndeavorNames
	{
		#region Infrastructure

	    public static IEndeavorNames Instance { get; } = new EndeavorNames();

	    private EndeavorNames()
	    {
        }

	    #endregion
	}
}