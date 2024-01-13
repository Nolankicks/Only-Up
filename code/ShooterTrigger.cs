using Sandbox;

public sealed class ShooterTrigger : Component, Component.ITriggerListener
{
	[Property] public SoundEvent soundFile {get; set;}
	[Property] public GameObject gameObject {get; set;}
	[Property] public GameObject gameObject1 {get; set;}
	[Property] public GameObject ragdoll {get; set;}
	[Property] public Vector3 vector3 {get; set;}
	[Property] public Rotation rotation {get; set;}
	
	
	

	bool iTouching = false;

	void OnDeath()
	{
	var gameObject = gameObject1; 
		Components.TryGet<SkinnedModelRenderer>(out var skinned2, FindMode.EnabledInSelf );
		var sp = skinned2.Transform.Position + vector3;

		
		
		//var be = gameObject.Components.Create<ParticleBoxEmitter>();
		//var modelRenderer = gameObject.Components.Create<ModelRenderer>();
		//modelRenderer.Model = Model.Load("models/dev/box.vmdl");
		//gameObject.Transform.Position = sp;
		gameObject.Clone(sp);
		Log.Info("Hello");
var sp1 = skinned2.Transform.Position;




		ragdoll.Clone(sp1, rotation);
		
		
	}


	void ITriggerListener.OnTriggerEnter(Collider other) 
	{
			
			
			if ( !other.GameObject.IsValid() )
            return;

        var health = other.GameObject.Components.GetInAncestorsOrSelf<SphereCollider>();
		var pos = gameObject.Transform.Local.Position;
		
        if ( health.IsValid() )
        {
            Log.Info("Hit");
			Sound.Play(soundFile);
			OnDeath();
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
