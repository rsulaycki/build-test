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
        	string projectParent = Directory.GetParent(Application.dataPath);
        	string buildname = Path.GetFileNameWithoutExtension(path);
        	Debug.Log("Project parent: " + projectParent + " buildname: " + buildname);
	}
	
	[PostProcessBuild(0)] // <- this is where the magic happens
	public static void OnPostProcessBuildFirst(BuildTarget target, string path)
	{
		Debug.Log("Post Process Build 0");
	}
	
}

