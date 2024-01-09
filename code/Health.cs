using Sandbox;

public sealed class Health : Component
{

	[Property] public SceneFile sceneFile {get; set;}
	public int healthNumber = 100;
	



	
	protected override void OnStart()
	{
			
	}
	
	//public void Restart()
	//{
		//if (healthNumber == 0)
		//{
			//GameManager.ActiveScene.Load(sceneFile);
		//}
	//}
	
	
	
	
	public void Death()
	{
		
		Log.Info("Death");
		GameManager.ActiveScene.Load(sceneFile);
			
	}


}
