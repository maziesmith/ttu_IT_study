using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections {
    public class Car {
        public string Maker { get; set; }
        public string Model { get; set; }

        public Car() {
            Maker = string.Empty;
            Model = string.Empty;
        }

        public Car(string maker) {
            Maker = maker;
        }

        public Car(string maker, string model) {
            Maker = maker;
            Model = model;
        }

        public override string ToString() {
            return Maker + " " + Model;
        }
    }
}
