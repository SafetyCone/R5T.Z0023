using System;


namespace R5T.Z0023
{
	public class ProjectDescriptions : IProjectDescriptions
	{
		#region Infrastructure

	    public static IProjectDescriptions Instance { get; } = new ProjectDescriptions();

	    private ProjectDescriptions()
	    {
        }

	    #endregion
	}
}