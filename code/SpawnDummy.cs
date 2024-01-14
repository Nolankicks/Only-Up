using Sandbox;

public sealed class SpawnDummy : Component
{
	[Property] GameObject dummy {get; set;}
	[Property] Rotation rotation {get; set;}

	
	protected override void OnUpdate()
	{
		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		var pcDir = pc.EyeAngles * rotation;
		if (Input.Pressed("Attack2"))
		
		{
			var pos = Transform.Position + Vector3.Up * 0.0f + lookDir.Forward.WithZ( 0.0f ) * 200.0f;
			//SceneUtility.Instantiate( Attack1, pos );
			
			dummy.Clone(pos, pcDir);
		}
	}
}
