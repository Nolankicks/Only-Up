using Sandbox;

public sealed class Shooter : Component
{
	[Property] GameObject bullet {get; set;}
	[Property] SoundEvent soundEvent {get; set;}
	[Property] GameObject parent {get; set;}

	protected override void OnFixedUpdate()
	{
		var pc = parent.Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		if ( Input.Pressed( "Attack1" ) )
		{
			var pos = Transform.Position + Vector3.Up * 64.0f;

			var o = bullet.Clone( pos);


			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 5000f;
			soundEvent.UI = true;
			Sound.Play(soundEvent);


		}
	}
}
