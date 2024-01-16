using Sandbox.Network;

namespace Sandbox;

public sealed class NetworkManager : Component, Component.INetworkListener
{
	[Property] public GameObject PlayerPrefab { get; set; }
	//[Property] public GameObject SpawnPoint { get; set; }
	  [Property, Net] public List<GameObject> SpawnPoints { get; set; } = new List<GameObject>();

	public void OnActive( Connection channel )
	{
		Log.Info( $"Player '{channel.DisplayName}' is becoming active" );
		Log.Info( $"Avatar: {channel.GetUserData( "avatar" )}" );
		

		var clothing = new ClothingContainer();
		clothing.Deserialize( channel.GetUserData( "avatar" ) );
		  if (SpawnPoints.Count == 0)
    {
        Log.Error("No spawn points set!");
        return;
    }

    int randomIndex = new Random().Next(SpawnPoints.Count);
    GameObject spawnPoint = SpawnPoints[randomIndex];

		var player = PlayerPrefab.Clone(SpawnPoints[randomIndex].Transform.World);

		// Assume that if they have a skinned model renderer, it's the citizen's body
		if (player.Components.TryGet<SkinnedModelRenderer>(out var body, FindMode.EverythingInSelfAndDescendants))
		{
			clothing.Apply(body);
		}
			
		player.Network.Spawn( channel );
	}
}
