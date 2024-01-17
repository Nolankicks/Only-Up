using Sandbox;

public class Despawner : Component {
  public TimeUntil destroy = 5f;
  protected override void OnFixedUpdate(){
    if(destroy < 0f)GameObject.Destroy();
	
  }
}
