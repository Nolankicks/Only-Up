using Sandbox;
using Sandbox.Network;

public sealed class Leave : Component
{
	protected override void OnUpdate()
	{
		if (Input.EscapePressed)
		{
			Game.Close();
			Log.Info("Quit");
			
		}
	}



}
