using System.Runtime.CompilerServices;
using Sandbox;


public sealed class HealthTrigger : Component, Component.ITriggerListener //Change "Trigger to the name of your file
{

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

    void ITriggerListener.OnTriggerEnter(Collider other)
    {
		

		_iTouching = true;
		Health.Death();

	   

         
    }

    void ITriggerListener.OnTriggerExit( Collider other ) 
    {

		

	
    

    }

	


	
}
