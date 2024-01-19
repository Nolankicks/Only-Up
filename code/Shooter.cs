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
	private TimeSince timesinceFire;
	private TimeSince test;



	


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
			if (timesinceFire > 0.2)
			{
			timesinceFire = 0;
			var pos = Transform.Position + Vector3.Up * 64.0f + lookDir.Forward.WithZ( 0.0f ) * 50.0f;
			var cloner = gameObject.Clone(pos);
			cloner.Enabled = true;
			citizenAnimationHelper.HoldType = holdTypes;
			citizenAnimationHelper.Target.Set("b_attack", true);
			var p = cloner.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 1000000f;
			soundEvent.UI = true;
			Sound.Play(soundEvent);
			//pc.Network.TakeOwnership();
			//o.Network.Spawn();
			cloner.Network.Spawn();
			
			}
			

			
			


		}
		if (timesinceFire > 0.5)
		{
			citizenAnimationHelper.HoldType = CitizenAnimationHelper.HoldTypes.None;
		}
		}			
	}


