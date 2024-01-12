using Sandbox;

public sealed class RemoveObject : Component
{
	[Property] GameObject objecttoRemove {get; set;}
	protected override void OnUpdate()
	{
		if (Input.Pressed("Attack1"))
		{
		objecttoRemove.Destroy();
		}
	}
}
