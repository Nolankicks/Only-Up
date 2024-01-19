using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using Sandbox;
using Sandbox.Citizen;

public sealed class Shooter : Component
{
	[Property] GameObject gameObject {get; set;}
	[Property] SoundEvent soundEvent {get; set;}

	[Property] public SkinnedModelRenderer skinnedModelRenderer {get; set;}
	
	[Property] Vector3 vector3 {get; set;}
	[Property] public CitizenAnimationHelper citizenAnimationHelper {get; set;}
	[Property] public CitizenAnimationHelper.HoldTypes holdTypes {get; set;}
	public TimeSince destroy = 3f;
	public TimeSince timeSince;
	


	


	protected override void OnFixedUpdate()
	{

		

		


			if (IsProxy)
			return;
		var skinnedModelRendererPos = skinnedModelRenderer.Transform.World;
		var anigraph = Components.GetInParentOrSelf<CitizenAnimationHelper>();
		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		
		if ( Input.Down( "Attack1" ) )
		{
			if (timeSince > 0.2)
			{
			timeSince = 0;
			var pos = Transform.Position + Vector3.Up * 64.0f + lookDir.Forward.WithZ( 0.0f ) * 50.0f;
			var o = gameObject.Clone(pos);
			o.Enabled = true;
			citizenAnimationHelper.HoldType = holdTypes;
			citizenAnimationHelper.Target.Set("b_attack", true);
			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 1000000f;
			soundEvent.UI = true;
			Sound.Play(soundEvent);
			//pc.Network.TakeOwnership();
			//o.Network.Spawn();
			o.Network.Spawn();
			}
			

			
			


		}
		if (Input.Released("attack1"))
		{
			citizenAnimationHelper.HoldType = CitizenAnimationHelper.HoldTypes.None;
		}

		

			
	}
}
