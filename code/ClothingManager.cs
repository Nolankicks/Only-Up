using System.Net.Http.Headers;
using Microsoft.VisualBasic;
using Sandbox;

public sealed class ClothingManager : Component
{

	public void OnActive( Connection channel)
	{
		var clothing = new ClothingContainer();
		clothing.Deserialize( channel.GetUserData( "avatar" ) );
		var player = GameObject.Components.Get<PlayerController>();
		if (player.Components.TryGet<SkinnedModelRenderer>(out var body, FindMode.EverythingInSelfAndDescendants))
		{
			clothing.Apply(body);
		}
	}
}
