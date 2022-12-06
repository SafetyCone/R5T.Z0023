using System;


namespace R5T.Z0023
{
	public class ProjectNames : IProjectNames
	{
		#region Infrastructure

	    public static IProjectNames Instance { get; } = new ProjectNames();

	    private ProjectNames()
	    {
        }

	    #endregion
	}
}