using Sandbox;

public sealed class ShooterTrigger : Component, Component.ITriggerListener
{

	[Property] public SoundEvent soundFile {get; set;}
	[Property] public GameObject dummymodel {get; set;}


	
	
	

	bool iTouching = false;

	


	void ITriggerListener.OnTriggerEnter(Collider other) 
	{
			
			Components.TryGet<DummyManager>(out var dummy, FindMode.EverythingInSelfAndAncestors);
			if ( !other.GameObject.IsValid() )
            return;
			if (!dummy.IsValid() )
			return;

        var sphere = other.GameObject.Components.GetInAncestorsOrSelf<SphereCollider>();

        if ( sphere.IsValid() )
        {
			Log.Info("Hit");
			Sound.Play(soundFile);
			GameObject.Destroy();
			other.GameObject.Destroy();
			dummy.OnDeath();		

			 
        }
	}

	void ITriggerListener.OnTriggerExit( Collider other ) 
	{
		


	}

}
