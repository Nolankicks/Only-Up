using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Sandbox;

public sealed class HealthManager : Component
{
	
	//[Property] public SceneFile sceneFile {get; set;}
	public long healthNumber {get; set;} = 100;
	[Property] public SceneFile sceneFile {get; set;}
	
	
	


	
	
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
	public void AtDeath()
	{

	}

		
	

	




	public void OnDeath()
	{
		
		healthNumber = 0;
		
		Log.Info(healthNumber);
		
		
		
			
	}
	public void OnObsticle()
	{
		

		 healthNumber -= 25;

	}
	



}
