using Sandbox;

public sealed class GameObjectTest : Component
{

	
	protected override void OnAwake()
	{
		var gameObject = GameObject;
		var modelRenderer = gameObject.Components.Create<ModelRenderer>();

		modelRenderer.Model = Model.Load("models/dev/box.vmdl");
		modelRenderer.Tint = Color.Red;
		
	}
}
