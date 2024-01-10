using Sandbox;
using Sandbox.Razor;

public sealed class PlayerSpawnLevel4 : Component
{


	[Property] public GameObject Attack1 {get; set;}
	[Property] public SoundEvent soundEvent {get; set;}




	
	protected override void OnUpdate()
	{
		var pc = Components.Get<PlayerController>();
		var lookDir = pc.EyeAngles.ToRotation();
		
		
		if (Input.Pressed("Attack1"))
		{
			var pos = Transform.Position + Vector3.Up * 200.0f + lookDir.Forward.WithZ( 0.0f ) * 300.0f;
			//SceneUtility.Instantiate( Attack1, pos );
			Sound.Play(soundEvent);
			Attack1.Clone(pos);
			
			


		}








}

}
