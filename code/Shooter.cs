using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Gunfight;
using Sandbox;
using Sandbox.Citizen;

public sealed class Shooter : Component
{
	[Property] GameObject gameObject {get; set;}
	[Property] SoundEvent soundEvent {get; set;}

	[Property] public SkinnedModelRenderer skinnedModelRenderer {get; set;}
	
	[Property] Vector3 vector3 {get; set;}
	[Property] public CitizenAnimationHelper citizenAnimationHelper {get; set;}
	public TimeSince destroy = 3f;
	[Property] public bool loop {get; set;}
	


	protected override void OnFixedUpdate()
	{

		

		


			if (IsProxy)
			return;
		var skinnedModelRendererPos = skinnedModelRenderer.Transform.World;
		var anigraph = Components.GetInParentOrSelf<CitizenAnimationHelper>();
		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		
		if ( Input.Pressed( "Attack1" ) )
		{

			var pos = Transform.Position + Vector3.Up * 64.0f + lookDir.Forward.WithZ( 0.0f ) * 50.0f;
			var o = gameObject.Clone(pos);
			o.Enabled = true;
			citizenAnimationHelper.HoldType = CitizenAnimationHelper.HoldTypes.Pistol;
			citizenAnimationHelper.Target.Set("b_attack", true);
			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 5000f;
			soundEvent.UI = true;
			Sound.Play(soundEvent);
			//pc.Network.TakeOwnership();
			//o.Network.Spawn();
			o.Network.Spawn();
			
			
			


		}
		if (Input.Released("attack1"))
		{
			citizenAnimationHelper.HoldType = CitizenAnimationHelper.HoldTypes.None;
		}
	}
}
