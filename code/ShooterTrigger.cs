using Sandbox;

public sealed class ShooterTrigger : Component, Component.ITriggerListener
{
	[Property] public SoundEvent soundFile {get; set;}
	[Property] public GameObject gameObject {get; set;}
	
	int iTouching;

	void ITriggerListener.OnTriggerEnter(Collider other) 
	{
		iTouching++;
			if ( !other.GameObject.IsValid() )
            return;

        var health = other.GameObject.Components.GetInAncestorsOrSelf<SphereCollider>();

        if ( health.IsValid() )
        {
            Log.Info("Hit");
			Sound.Play(soundFile);
			GameObject.Destroy();
			
			 
        }
    



			



	}

	void ITriggerListener.OnTriggerExit( Collider other ) 
	{
		iTouching--;


	}

}
