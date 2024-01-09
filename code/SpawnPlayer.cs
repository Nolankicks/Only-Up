using Sandbox;
using Sandbox.Razor;

public sealed class SpawnPlayer : Component
{


	[Property] public GameObject Attack1 {get; set;}
	[Property] public GameObject Attack2 {get; set;}
	[Property] public SoundEvent soundEvent {get; set;}
	[Property] Rotation rotation {get; set;}
	[Property] SceneFile reloadScene {get; set;}



	
	protected override void OnUpdate()
	{
		var pc = Components.Get<PlayerController>();
		var lookDir = pc.EyeAngles.ToRotation();
		
		
		if (Input.Pressed("Attack1"))
		{
			var pos = Transform.Position + Vector3.Up * 200.0f + lookDir.Forward.WithZ( 0.0f ) * 200.0f;
			SceneUtility.Instantiate( Attack1, pos );
			Sound.Play(soundEvent);
			
			


		}

		if (Input.Pressed("Attack2"))
		{
		var pos = Transform.Position + Vector3.Up * 1.0f + lookDir.Forward.WithZ( 0.0f ) * 200.0f;
			SceneUtility.Instantiate( Attack2, pos, rotation );
			Sound.Play(soundEvent);
	



			
		}



		if (Input.Pressed("reload"))
		{
			GameManager.ActiveScene.Load(reloadScene);
		}
	}


}
