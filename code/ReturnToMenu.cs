using Sandbox;

public sealed class ReturnToMenu : Component
{
	[Property] public SoundEvent soundEvent {get; set;}
	[Property] public SceneFile menuScene {get; set;}
	protected override void OnUpdate()
	{
		if ( Input.EscapePressed )
		{
			GameManager.ActiveScene.Load(menuScene);
			Sound.Play(soundEvent);
		}
	}
}
