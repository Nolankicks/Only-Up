using Sandbox;

public sealed class NetworkSession : Component
{
	protected override void OnUpdate()
	{
		if ( IsProxy )
			return;
			
		var pc = Components.Get<PlayerController2>();
		var lookDir = pc.EyeAngles.ToRotation();
	}
}
