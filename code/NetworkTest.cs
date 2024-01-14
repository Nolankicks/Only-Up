using Sandbox;
using System.Threading;

public sealed class NetworkTest : Component
{
	[Property] public GameObject ObjectToSpawn { get; set; }





	protected override void OnUpdate()
	{


		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
		
		if ( Input.Pressed( "Attack1" ) )
		{
			var pos = Transform.Position + Vector3.Up * 40.0f + lookDir.Forward.WithZ( 0.0f ) * 50.0f;

			var o = ObjectToSpawn.Clone( pos);
			o.Enabled = true;

			var p = o.Components.Get<Rigidbody>();
			p.Velocity = lookDir.Forward * 500.0f;
			
			
		}



	}

}
