using Sandbox;

public sealed class SpawnDummy : Component
{
	[Property] GameObject dummy {get; set;}
	[Property] Rotation rotation {get; set;}

	
	protected override void OnUpdate()
	{
		if ( IsProxy )
		return;

		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		var pcDir = pc.EyeAngles * rotation;
		if (Input.Pressed("Attack2"))
		
		{
			var pos = Transform.Position + Vector3.Up * 0.0f + lookDir.Forward.WithZ( 0.0f ) * 200.0f;
			var o = dummy.Clone(pos, pcDir);
			
			o.Network.Spawn();
			
		}
	}
}
