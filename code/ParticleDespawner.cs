using Sandbox;

public class ParticleDespawner : Component {
  public TimeUntil destroy = 3.7f;
  protected override void OnFixedUpdate(){
    if(destroy < 0f)GameObject.Destroy();
	
  }
}
