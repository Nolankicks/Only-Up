using Sandbox;

public sealed class DummyManager : Component
{


	[Property] public GameObject gameObject1 {get; set;}
	[Property] public GameObject ragdoll {get; set;}
	[Property] public Vector3 vector3 {get; set;}
	[Property] public Rotation rotation {get; set;}
	protected override void OnUpdate()
	{

	}
	public void OnDeath()
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
}
