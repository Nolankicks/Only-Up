using Sandbox;

public sealed class Respawn : Component
{

	 
	[Property] public Vector3 vector3 {get; set;}
	protected override void OnUpdate()
	{
		var startLocation = Transform.World;
		var cc = Components.GetInParentOrSelf<PlayerController2>();
		var spawnPoints = Scene.GetAllComponents<SpawnPoint>().ToList();
		startLocation = spawnPoints[Random.Shared.Int(0, spawnPoints.Count - 1)].Transform.World;
		if (spawnPoints.Count > 0)
		{
			startLocation = spawnPoints[Random.Shared.Int(0, spawnPoints.Count - 1)].Transform.World;
		}
		if (Input.Pressed("reload"))
		{
			cc.Transform.Position = startLocation.Position;
			Log.Info("Respawned");
		}
	}
}
