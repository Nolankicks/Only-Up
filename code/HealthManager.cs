using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Sandbox;

public sealed class HealthManager : Component
{
	
	//[Property] public SceneFile sceneFile {get; set;}
	public long healthNumber {get; set;} = 100;
	[Property] public SceneFile sceneFile {get; set;}
	[Property] public PlayerController2 playerController2 {get; set;}
	[Property] public Vector3 vector3 {get; set;}
	
	
	


	
	
	protected override void OnStart()
	{
		healthNumber = 100;
	}
	
	protected override void OnUpdate()
	{
				if (healthNumber == 0)
			{
				playerController2.Transform.Position = vector3;
				healthNumber = 100;

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
