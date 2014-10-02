using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public static class PostBuildTrigger
{

	[PostProcessBuild] // <- this is where the magic happens
	public static void OnPostProcessBuild(BuildTarget target, string path)
	{
		Debug.Log("Post Processing Build 1");
		// Get Required Paths
        	projectParent = Directory.GetParent(Application.dataPath);
        	buildname = Path.GetFileNameWithoutExtension(path);
 
        	// Do Certain actions on your files (Copy, remove or email them to NASA your decision)
        	filecount = 0;
        	dircount = 0;
//        	CopyAll(new DirectoryInfo(projectParent.ToString() + divider + srcName), new DirectoryInfo(buildDataDir));
 
        	Debug.Log("Project parent: + projectParent + " buildname:" + buildname);
	}
	
	[PostProcessBuild(0)] // <- this is where the magic happens
	public static void OnPostProcessBuildFirst(BuildTarget target, string path)
	{
		Debug.Log("Post Process Build 0");
	}
	
}

