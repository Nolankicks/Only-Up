using Sandbox;

public sealed class Shooter : Component
{
	[Property] GameObject gameObject {get; set;}
	[Property] SoundEvent soundEvent {get; set;}

	protected override void OnUpdate()
	{
		var pc = Components.Get<PlayerController>();
		var lookDir = pc.EyeAngles.ToRotation();
		if ( Input.Pressed( "Attack1" ) )
		{
			var pos = Transform.Position + Vector3.Up * 64.0f;

			var o = gameObject.Clone( pos);
			o.Enabled = true;

			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 5000f;
			soundEvent.UI = true;
			Sound.Play(soundEvent);


		}
	}
}
