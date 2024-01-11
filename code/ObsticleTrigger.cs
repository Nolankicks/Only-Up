using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Sandbox;

[Group( "Trigger" )]
public sealed class ObsticleTrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{
[Property] public HealthManager health {get; set;}
[Property] public SoundEvent soundEvent {get; set;}
 bool _iTouching = false;
 







	protected override void OnStart()
    {
      _iTouching = false;
		
    }

    public void OnTriggerEnter( Collider other )
    {
_iTouching = true;
var health = other.GameObject.Components.GetInParentOrSelf<HealthManager>();
		
		if (other.Tags.Has("Player"))
{		
		{
			  
		health.OnObsticle();
		Sound.Play(soundEvent);
		}
}

    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {
		return;
		

	
    

    }

	


	
}
