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
		string strCmdText= "dir";
		System.Diagnostics.Process p = new Process();
		p.StartInfo.RedirectStandardOutput = true;
		p.Start("CMD.exe",strCmdText);		
		string output = p.StandardOutput.ReadToEnd();
		Debug.Log("RS: The output of p is:" + output);
	}
	
	[PostProcessBuild(0)] // <- this is where the magic happens
	public static void OnPostProcessBuildFirst(BuildTarget target, string path)
	{
		Debug.Log("Post Process Build 0");
	}
	
}

