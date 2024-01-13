using Sandbox;

public sealed class ShooterTrigger : Component, Component.ITriggerListener
{

	[Property] public SoundEvent soundFile {get; set;}
	[Property] public GameObject gameObject {get; set;}
	[Property] public GameObject gameObject1 {get; set;}
	[Property] public GameObject ragdoll {get; set;}
	[Property] public Vector3 vector3 {get; set;}
	[Property] public Rotation rotation {get; set;}
	//[Property] public DummyManager dummy {get; set;}
	
	
	

	bool iTouching = false;

	


	void ITriggerListener.OnTriggerEnter(Collider other) 
	{
			
			Components.TryGet<DummyManager>(out var dummy, FindMode.EverythingInSelfAndAncestors);
			if ( !other.GameObject.IsValid() )
            return;
			if (!dummy.IsValid())
			return;

        var sphere = other.GameObject.Components.GetInAncestorsOrSelf<SphereCollider>();
		var pos = gameObject.Transform.Local.Position;
		
		
        if ( sphere.IsValid() )
        {
            Log.Info("Hit");
			Sound.Play(soundFile);
			dummy.OnDeath();
			GameObject.Destroy();
			other.GameObject.Destroy();
			gameObject1.Destroy();			
			//var modelRenderer = terry.Components.Create<ModelRenderer>();
			
			
			
			
			//terryObject.Components.Create<ModelRenderer>();
			
			
			
			
			 
        }

    



			



	}

	void ITriggerListener.OnTriggerExit( Collider other ) 
	{
		


	}

}
