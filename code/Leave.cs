using Sandbox;
using Sandbox.Network;

public sealed class Leave : Component
{
	protected override void OnUpdate()
	{
		if (Input.EscapePressed)
		{
			GameNetworkSystem.Disconnect();
			GameManager.ActiveScene.LoadFromFile("scenes/menu.scene");

		}
	}



}
