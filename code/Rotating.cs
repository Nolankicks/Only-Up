using Sandbox;

public sealed class Rotating : Component
{
	[Property] public Rotation rotation {get; set;}
	[Property] public bool rotate {get; set;}
	protected override void OnUpdate()
	{
			if (rotate)
			{
			GameObject.Transform.Rotation *= rotation;
			}
	}
}
