using FubuMVC.Core.Registration.Nodes;
using FubuMVC.Core.Registration.ObjectGraph;

namespace FubuMVC.Core.Security.AntiForgery
{
    public class AntiForgeryNode : BehaviorNode
    {
        private readonly string _salt;

        public AntiForgeryNode(string salt)
        {
            _salt = salt;
        }

        public override BehaviorCategory Category
        {
            get { return BehaviorCategory.Wrapper; }
        }

        protected override ObjectDef buildObjectDef()
        {
            return new ObjectDef(typeof (AntiForgeryBehavior))
            {
                Dependencies = {new ValueDependency {DependencyType = typeof (string), Value = _salt}}
            };
        }
    }
}