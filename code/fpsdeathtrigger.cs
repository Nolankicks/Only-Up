using System.Runtime.CompilerServices;
using Sandbox;
using Sandbox.UI;

public sealed class fpsdeathtrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{

 bool _iTouching; 
 [Property] public GameObject emitter {get; set;}
 [Property] public GameObject ragdol {get; set;}
 [Property] public HealthManager health {get; set;}



	protected override void OnStart()
    {
      _iTouching = false;
    }
	protected override void OnFixedUpdate()
    {
		var health = Components.GetInParentOrSelf<HealthManager>();
      if (_iTouching)
	  {
		Log.Info("playerhit");
   		health.OnDeath();
	  }
    }

    void ITriggerListener.OnTriggerEnter(Collider other)
    {

		if (other.Tags.Has("bullet"))
		{
		_iTouching = true;
		} 
    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {
	_iTouching = false;
    }	
}
