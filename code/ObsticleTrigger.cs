using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Sandbox;

[Group( "Trigger" )]
public sealed class ObsticleTrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{
[Property] public Health health {get; set;}
[Property] public SoundEvent soundEvent {get; set;}
 bool _iTouching; 

 public void istouching(bool _iTouching)
 {
		if (_iTouching == true)
		{
			
		}
 }



	protected override void OnStart()
    {
      _iTouching = false;
		
    }

    public void OnTriggerEnter( Collider other )
    {

		if (other.Tags.Has("Player"))
{
		health.healthNumber = health.healthNumber - 25;
		Sound.Play(soundEvent);
}
    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {

		

	
    

    }

	


	
}
