using Sandbox;

public sealed class SpawnPlayer : Component
{


	[Property] public GameObject objectToSpawn {get; set;}
	
	protected override void OnUpdate()
	{
		var pc = Components.Get<PlayerController>();
		var lookDir = pc.EyeAngles.ToRotation();
		
		
		if (Input.Pressed("Attack1"))
		{
			var pos = Transform.Position + Vector3.Up * 200.0f + lookDir.Forward.WithZ( 0.0f ) * 200.0f;
			SceneUtility.Instantiate( objectToSpawn, pos );
	
			
			


		}

	}

}
