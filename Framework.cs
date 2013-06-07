using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class Framework : MonoBehaviour {

    [SerializeField]
    private bool Puppet_Manager = false;
  [SerializeField]
    private bool Module_Manager = false;
	
    // Managers
    private PuppetManager puppets = null;
	private ModuleManager module = null;

	void Start() {
	    this.CreateManagers();
		this.CreateProviders();
		
		this.LoadContext(this.puppets, this.module);
		
		this.puppets.addPuppet("mecha", gameObject.AddComponent("PlayerControlObject") as Mecha);
		this.puppets.addPuppet("demon", gameObject.AddComponent("PlayerControlObject") as Demon);
		this.puppets.addPuppet("laser", gameObject.AddComponent("PlayerControlObject") as Laser);
	}
    
    private void CreateManagers()
    {
        if (this.Puppet_Manager)
        {
            this.puppets = new PuppetManager();
        }
		
		if (this.Module_Manager)
		{
			this.module = new ModuleManager();
		}
    }

    private void CreateProviders()
    {
    }
	
	private void LoadContext(params IContext[] context)
	{
		for(int i = 0; i < context.Length; i++)
		{
			if((context[i] == null)||(context[i].IsLoaded))
				continue;
			
			context[i].Load();
		}
	}
	
	public static Framework Instance
	{
		get
		{
			if(GameObject.Find("GlobalGameObject"))
			{
				return GameObject.Find("GlobalGameObject").GetComponent<Framework>();
			}
			
			return null;
		}
	}
	
	public PuppetManager PuppetManager
	{
		get { return this.puppets; }
	}
	
	public ModuleManager ModuleManager
	{
		get { return this.module; }
	}
}
