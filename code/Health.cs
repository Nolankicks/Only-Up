using System.Runtime.CompilerServices;
using Sandbox;

public sealed class Health : Component
{

	[Property] public SceneFile sceneFile {get; set;}
	public long healthNumber {get; set;} = 100;
	
	
	


	
	
	protected override void OnStart()
	{

	}
	
	protected override void OnUpdate()
	{

			
			if (healthNumber == 0)
			{
				GameManager.ActiveScene.Load(sceneFile);
				
			}

	}
	

	
	
	
	
	public void OnDeath()
	{
		healthNumber = 50;
		Log.Info(healthNumber);
		
		
			
	}



}
