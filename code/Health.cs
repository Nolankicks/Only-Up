using Sandbox;

public sealed class Health : Component
{

	[Property] public SceneFile sceneFile {get; set;}
	public int healthNumber;

	
	protected override void OnStart()
	{
			healthNumber = 100;
	}
	
	
	
	
	
	
	public static void Death()
	{
		
		Log.Info("Death");
		
			
	}





}
