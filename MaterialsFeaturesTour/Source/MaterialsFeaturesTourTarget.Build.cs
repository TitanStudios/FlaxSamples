using Flax.Build;

public class MaterialsFeaturesTourTarget : GameProjectTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for game
        Modules.Add("MaterialsFeaturesTour");
    }
}
