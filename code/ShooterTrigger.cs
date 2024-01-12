using Sandbox;

public sealed class ShooterTrigger : Component, Component.ITriggerListener
{
	[Property] public SoundEvent soundFile {get; set;}
	[Property] public GameObject gameObject {get; set;}

	
	
	

	bool iTouching = false;

	void ITriggerListener.OnTriggerEnter(Collider other) 
	{
			
			
			if ( !other.GameObject.IsValid() )
            return;

        var health = other.GameObject.Components.GetInAncestorsOrSelf<SphereCollider>();

		
        if ( health.IsValid() )
        {
            Log.Info("Hit");
			Sound.Play(soundFile);
			GameObject.Destroy();
			other.GameObject.Destroy();
			//var modelRenderer = terry.Components.Create<ModelRenderer>();
			
			
			
			//terryObject.Components.Create<ModelRenderer>();
			
			
			
			
			 
        }

    



			



	}

	void ITriggerListener.OnTriggerExit( Collider other ) 
	{
		


	}

}
