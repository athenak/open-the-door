using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp;

public class ModuleManager : IContext
{  
	private Dictionary<string, int> modules = new Dictionary<string, int>();
    private string currentModuleName = string.Empty;
	private bool isloaded = false;
	
	public void Load ()
	{
		this.isloaded = true;
		Debug.Log("Module Manager Loaded!");
	}

	public void Unload ()
	{
		this.isloaded = false;
	}
	
	public bool IsLoaded
	{
		get { return this.isloaded; }	
	}
	
	public string CurrentModule
	{
		get { return this.currentModuleName; }	
	}
}
