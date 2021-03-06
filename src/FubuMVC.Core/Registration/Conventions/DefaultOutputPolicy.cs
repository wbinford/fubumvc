using FubuMVC.Core.Resources.Conneg;

namespace FubuMVC.Core.Registration.Conventions
{
    public class DefaultOutputPolicy : Policy
    {
        public DefaultOutputPolicy()
        {
            Where.IsNotPartial();
            Where.ChainMatches(x => x.HasResourceType() && !x.HasOutput());
            ModifyBy(chain => chain.ApplyConneg(), configurationType: ConfigurationType.Conneg);
        }
    }
}