using Gunfight;
using Sandbox;

public sealed class Shooter : Component
{
	[Property] GameObject gameObject {get; set;}
	[Property] SoundEvent soundEvent {get; set;}


	protected override void OnUpdate()
	{
			if (IsProxy)
			return;

		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		if ( Input.Pressed( "Attack1" ) )
		{
			var pos = Transform.Position + Vector3.Up * 64.0f + lookDir.Forward.WithZ( 0.0f ) * 50.0f;
			var o = gameObject.Clone( pos);
			o.Enabled = true;
			
			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 5000f;
			soundEvent.UI = true;
			Sound.Play(soundEvent);
			//pc.Network.TakeOwnership();
			//o.Network.Spawn();
			o.Network.Spawn();
			
			


		}
	}
}
