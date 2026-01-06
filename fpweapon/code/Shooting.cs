using Sandbox;

public sealed class Shooting : Component
{
	[Property] public SkinnedModelRenderer v_mp5 { get; set; }
	protected override void OnUpdate()
	{

		if ( Input.Pressed( "attack1" ) )
		{
			v_mp5.Set( "b_attack", true );
		}
	}
}
