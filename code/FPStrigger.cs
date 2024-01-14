using System.Runtime.CompilerServices;
using Sandbox;

public sealed class FPStrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{

 bool _iTouching; 
 



	protected override void OnStart()
    {
      _iTouching = false;

    }

    void ITriggerListener.OnTriggerEnter(Collider other)
    {
		

		
    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {
		
		
	}
}

