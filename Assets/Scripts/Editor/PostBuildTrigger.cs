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
		string command= "dir";
		System.Diagnostics.ProcessStartInfo procStartInfo =new System.Diagnostics.ProcessStartInfo("cmd", "/c " + command);

   		procStartInfo.RedirectStandardOutput = true;
    		procStartInfo.UseShellExecute = false;
    		// Do not create the black window.
    		procStartInfo.CreateNoWindow = true;
    		// Now we create a process, assign its ProcessStartInfo and start it
    		System.Diagnostics.Process proc = new System.Diagnostics.Process();
    		proc.StartInfo = procStartInfo;
    		proc.Start();
    		// Get the output into a string
    		string result = proc.StandardOutput.ReadToEnd();
		Debug.Log("RS: The output of p is: ", result);
	}
	
	[PostProcessBuild(0)] // <- this is where the magic happens
	public static void OnPostProcessBuildFirst(BuildTarget target, string path)
	{
		Debug.Log("Post Process Build 0");
	}
	
}

