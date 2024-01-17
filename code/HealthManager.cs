using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Sandbox;

public sealed class HealthManager : Component
{
	
	//[Property] public SceneFile sceneFile {get; set;}
	public long healthNumber {get; set;} = 100;
	[Property] public PlayerController2 playerController2 {get; set;}
	[Property] public Vector3 vector3 {get; set;}
	[Property] public SoundEvent hitsound {get; set;}
	 [Property] public GameObject emitter {get; set;}
 	[Property] public GameObject ragdol {get; set;}
	
	
	


	
	
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
		Sound.Play(hitsound);
		if (0 >= healthNumber)
		{
		var finalpos = vector3 + Vector3.Up * 64f;
		var emittervar = emitter.Clone(finalpos);
		emittervar.Network.Spawn();
		Log.Info(healthNumber);
		}
		
		
			
	}
	public void OnObsticle()
	{
		

		 healthNumber -= 25;

	}
	



}
