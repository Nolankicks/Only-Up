using Sandbox;

public sealed class DestroyTrigger : Component, Component.ITriggerListener
{

	[Property] public SphereCollider sphereCollider {get; set;}
	bool iTouching;
			protected override void OnUpdate()
		{
			var gameObject = GameObject.Components.GetInParentOrSelf<ModelRenderer>();
			if (iTouching)
			{
				gameObject.Destroy();
			}
		}

	void ITriggerListener.OnTriggerEnter( Collider other ) 
	{
		if (Tags.Has("map"))
		{
		iTouching = true;
		}


	}

	void ITriggerListener.OnTriggerExit( Collider other ) 
	{

	}

}
