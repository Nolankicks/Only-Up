using System.Runtime.CompilerServices;
using Sandbox;

public sealed class fpsdeathtrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{

 bool _iTouching; 
 [Property] public HealthManager healthManager {get; set;}



	protected override void OnStart()
    {
      _iTouching = false;

    }
	protected override void OnFixedUpdate()
    {
      if (_iTouching)
	  {
		Log.Info("playerhit");
		healthManager.healthNumber = 0;
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
