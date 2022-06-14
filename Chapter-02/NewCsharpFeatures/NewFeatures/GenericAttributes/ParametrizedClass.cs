namespace NewFeatures.GenericAttributes;

public class ParametrizedClass
{
    [OldTypeAttribute(typeof(int))]
    public int DoOldStyleJob() => default;

    [NewTypeAttribute<int>]
    public int DoNewStyleJob() => default;

}