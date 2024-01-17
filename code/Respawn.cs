using Sandbox;

public sealed class Respawn : Component
{

	 
	[Property] public Vector3 vector3 {get; set;}
	protected override void OnUpdate()
	{
		var cc = Components.GetInParentOrSelf<PlayerController2>();
		if (Input.Pressed("reload"))
		{
			cc.Transform.Position = vector3;
			Log.Info("Respawned");
		}
	}
}
