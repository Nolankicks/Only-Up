using Sandbox;

public sealed class DummyManager : Component
{


	[Property] public GameObject emitterObj {get; set;}
	[Property] public GameObject ragdollObj {get; set;}
	[Property] public Vector3 vector3 {get; set;}
	[Property] public Rotation rotation {get; set;}
	[Property] public ShooterTrigger shooterTrigger {get; set;}
	
	protected override void OnUpdate()
	{

	}
	public void OnDeath()
	{
		var emitter = emitterObj; 
		var ragdoll = ragdollObj;
		var obj = GameObject;
		var ro = obj.Transform.Rotation;
		var fnro = ro;
		
		
		Components.TryGet<SkinnedModelRenderer>(out var skinned2, FindMode.EnabledInSelf );
		var sp = skinned2.Transform.Position + vector3;
		emitter.Clone(sp);
		Log.Info("Hello");
		var sp1 = skinned2.Transform.Position;
		ragdoll.Clone(sp1, fnro);
		
		
	}
}
