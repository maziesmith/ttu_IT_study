using System;

namespace Attributes {
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    public class AuthorAttribute : Attribute {
        private string _name = string.Empty;
        private int _version = 0;

        public AuthorAttribute(string name) {
            _name = name;
        }

        // This property is readonly (it has no set accessor) so it cannot be used as a named argument to this attribute.
        public string Name {
            get {
                return _name;
            }
        }

        // This property is read-write (it has a set accessor) so it can be used as a named argument when using this class as an attribute class.
        public int Version {
            get {
                return _version;
            }
            set {
                _version = value;
            }
        }

        public override string ToString() {
            string value = $"Author: {_name}";

            if (_version > 0) {
                value += $" Version: {_version.ToString()}";
            }

            return value;
        }
    }
}
