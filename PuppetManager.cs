using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using AssemblyCSharp;

public class PuppetManager : IContext
{
    private Dictionary<string, BasePuppet> puppets = new Dictionary<string, BasePuppet>();
  private bool isloaded = false;
	
	private string currentPuppetName = string.Empty;
	
	public void Load ()
	{
		this.isloaded = true;
		Debug.Log("Puppet Manager Loaded!");
	}

	public void Unload ()
	{
		this.isloaded = false;
	}
	
	public bool IsLoaded
	{
		get { return this.isloaded; }	
	}
	
	public void pushPuppet(string name)
    {
		if(!this.puppets.ContainsKey(name))
			return;
		
		if(this.currentPuppetName != null)
			this.puppets[currentPuppetName].Deactivate();
		
		this.currentPuppetName = name;
		this.puppets[name].Activate();
    }

    public void addPuppet(string name, BasePuppet puppet)
    {
        if (!this.puppets.ContainsKey(name))
        {
            Debug.Log("Adding Puppet " + name);
            this.puppets.Add(name, puppet);
        }
        else
        {
            Debug.Log("Puppet already exists");
        }
    }

    public void removePuppet(string name)
    {
        if (this.puppets.ContainsKey(name))
        {
            Debug.Log("Removing Puppet");
            this.puppets.Remove(name);
        }
        else
        {
            Debug.Log("Does not contain Puppet");
        }
    }

    public string CurrentPuppet
    {
        get { return this.currentPuppetName; }
    }
}
