namespace Sandbox;

public sealed class GameNetworkManager2 : Component, Component.INetworkListener
{
	[Property] public GameObject PlayerPrefab { get; set; }
	[Property] public GameObject SpawnPoint { get; set; }

	public void OnActive( Connection channel )
	{


		var clothing = new ClothingContainer();
		clothing.Deserialize( channel.GetUserData( "avatar" ) );

		var player = PlayerPrefab.Clone( SpawnPoint.Transform.World );



		// Assume that if they have a skinned model renderer, it's the citizen's body
		if ( player.Components.TryGet<SkinnedModelRenderer>( out var body, FindMode.EverythingInSelfAndDescendants ) )
		{
			clothing.Apply( body );
		}

		player.Network.Spawn(channel);
	}
}
