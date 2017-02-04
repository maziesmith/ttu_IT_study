using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Rakendus.Models {
    partial class Inventory : INotifyPropertyChanged {
        private int _carId;
        private string _make;
        private string _color;
        private string _petName;
        private bool _isChanged;

        public event PropertyChangedEventHandler PropertyChanged;

        public int CarId {
            get {
                return _carId;
            }

            set {
                if (value == _carId) {
                    return;
                }

                _carId = value;
                OnPropertyChanged();
            }
        }

        public string Make {
            get {
                return _make;
            }

            set {
                if (value == _make) {
                    return;
                }

                _make = value;
                OnPropertyChanged();
            }
        }

        public string Color {
            get {
                return _color;
            }

            set {
                if (value == _color) {
                    return;
                }

                _color = value;
                OnPropertyChanged();
            }
        }

        public string PetName {
            get {
                return _petName;
            }

            set {
                if (value == _petName) {
                    return;
                }

                _petName = value;
                OnPropertyChanged();
            }
        }

        public bool IsChanged {
            get {
                return _isChanged;
            }
            set {
                if (value == _isChanged) {
                    return;
                }

                _isChanged = value;
                OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            if (propertyName != nameof(IsChanged)) {
                IsChanged = true;
            }

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

