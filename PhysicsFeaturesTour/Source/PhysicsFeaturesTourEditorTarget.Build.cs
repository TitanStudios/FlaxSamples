using Flax.Build;

public class PhysicsFeaturesTourEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("PhysicsFeaturesTour");
    }
}
