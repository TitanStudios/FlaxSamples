using Flax.Build;

public class ParticlesFeaturesTourTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("ParticlesFeaturesTour");
    }
}
