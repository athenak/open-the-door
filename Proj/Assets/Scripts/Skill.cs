using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour
{
	enum Attacks { SPLASH_DAMAGE_ON_ATTACK, STUN, AOE_ON_CHAR, AOE_RANGED, KNOCKBACK, 
				LONG_RANGED_ATTACK, SHORT_RANGED_ATTACK, MELEE_ATTACK };
	enum NonAttacks { DODGE, JUMP, STAT_CHANGE, INVULNERABILITY };//we could potentially
	//merge everything but JUMP with STAT_CHANGE if we make everything else fall under stats
	
	//Suggested stats: health, mana, dodge, attack speed, aggro (mob's interest in attacking a character, which
	//for a character like Mecha, would be increased, but may be lowered for another one?), resistance (to elemental
	//damage, armor (to physical and non-elemental ranged damage).  Might be missing some.  And I think these would
	//apply to enemies too, so they could go up in BaseChar.  I was also thinking about visibility, in case we
	//ever wanted to make a skill where a player could be temporarily invisible?
	
	public Attacks SPLASH_DAMAGE_ON_ATTACK{
		get{
			return SPLASH_DAMAGE_ON_ATTACK;
		}
		set{
			SPLASH_DAMAGE_ON_ATTACK = value;
		}
	}
	public Attacks STUN{
		get{
			return STUN;
		}
		set{
			STUN = value;
		}
	}
	public Attacks AOE_ON_CHAR{
		get{
			return AOE_ON_CHAR;
		}
		set{
			AOE_ON_CHAR = value;
		}
	}
	public Attacks AOE_RANGED{
		get{
			return AOE_RANGED;
		}
		set{
			AOE_RANGED = value;
		}
	}
	public Attacks KNOCKBACK{
		get{
			return KNOCKBACK;
		}
		set{
			KNOCKBACK = value;
		}
	}
	public Attacks LONG_RANGED_ATTACK{
		get{
			return LONG_RANGED_ATTACK;
		}
		set{
			LONG_RANGED_ATTACK = value;
		}
	}
	public Attacks SHORT_RANGED_ATTACK{
		get{
			return SHORT_RANGED_ATTACK;
		}
		set{
			SHORT_RANGED_ATTACK = value;
		}
	}
	public Attacks MELEE_ATTACK{
		get{
			return MELEE_ATTACK;
		}
		set{
			MELEE_ATTACK = value;
		}
	}
	public NonAttacks DODGE{
		get{
			return DODGE;
		}
		set{
			DODGE = value;
		}
	}
	public NonAttacks JUMP{
		get{
			return JUMP;
		}
		set{
			JUMP = value;
		}
	}
	public NonAttacks STAT_CHANGE{
		get{
			return STAT_CHANGE;
		}
		set{
			STAT_CHANGE = value;
		}
	}
	public NonAttacks INVULNERABILITY{
		get{
			return INVULNERABILITY;
		}
		set{
			INVULNERABILITY = value;
		}
	}
	//Am I correct in assuming that Start() and Update() will be handled elsewhere and are unnecessary for
	//Skill?
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

