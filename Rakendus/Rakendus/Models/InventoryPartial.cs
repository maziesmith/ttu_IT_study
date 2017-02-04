using System.ComponentModel;

namespace Rakendus.Models {
    public partial class Inventory : IDataErrorInfo {
        public string Error { get; }

        public string this[string columnName] {
            get {
                switch (columnName) {
                    case nameof(CarId):
                        break;

                    case nameof(Make):
                        if (Make == "ModelT") {
                            return "Too Old";
                        }
                        // 1393
                        return CheckMakeAndColor();

                    case nameof(Color):
                        return CheckMakeAndColor();

                    case nameof(PetName):
                        break;
                }

                return string.Empty;
            }
        }

        internal string CheckMakeAndColor() {
            if (Make == "Chevy" && Color == "Pink") {
                return $"{Make}'s don't come in {Color}";
            }

            return string.Empty;
        }
    }
}
