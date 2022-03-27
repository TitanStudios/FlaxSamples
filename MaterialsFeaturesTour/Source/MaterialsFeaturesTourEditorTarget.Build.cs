using Flax.Build;

public class MaterialsFeaturesTourEditorTarget : GameProjectEditorTarget
{
    /// <inheritdoc />
    public override void Init()
    {
        base.Init();

        // Reference the modules for editor
        Modules.Add("MaterialsFeaturesTour");
    }
}
