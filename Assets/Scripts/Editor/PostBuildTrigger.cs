using System.IO;
using System.Diagnostics;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public static class PostBuildTrigger
{

	[PostProcessBuild] // <- this is where the magic happens
	public static void OnPostProcessBuild(BuildTarget target, string path)
	{
		Debug.Log("Post Processing Build 1");
		string strCmdText= "ls -l";
		System.Diagnostics.Process.Start("CMD.exe",strCmdText);		
	}
	
	[PostProcessBuild(0)] // <- this is where the magic happens
	public static void OnPostProcessBuildFirst(BuildTarget target, string path)
	{
		Debug.Log("Post Process Build 0");
	}
	
}

