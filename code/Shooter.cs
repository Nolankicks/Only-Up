using Sandbox;

public sealed class Shooter : Component
{
	[Property] GameObject gameObject {get; set;}

	protected override void OnUpdate()
	{
		var pc = Components.Get<PlayerController>();
		var lookDir = pc.EyeAngles.ToRotation();
		if ( Input.Pressed( "Attack1" ) )
		{
			var pos = Transform.Position + Vector3.Up * 40.0f + lookDir.Forward.WithZ( 0.0f ) * 50.0f;

			var o = gameObject.Clone( pos);
			o.Enabled = true;

			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 10000.0f + Vector3.Up * 200.0f;

			
		}
	}
}
