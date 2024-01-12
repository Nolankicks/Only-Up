using Sandbox;

public sealed class GameObjectTest : Component
{
	[Property] public Material material {get; set;}
	
	protected override void OnAwake()
	{
		var gameObject = GameObject;
		var modelRenderer = gameObject.Components.Create<ModelRenderer>();
		var trigger = gameObject.Components.Create<BoxCollider>();
		var body = gameObject.Components.Create<Rigidbody>();
		modelRenderer.Model = Model.Load("models/dev/box.vmdl");
		modelRenderer.MaterialOverride = material;
		
		
	}
}
