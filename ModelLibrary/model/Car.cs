using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary.model
{
    public class Car
    {
        private string _model;
        private string _color;
        private string _regNumber;

        public Car()
        {
        }

        public Car(string model, string color, string regNumber)
        {
            _model = model;
            _color = color;
            _regNumber = regNumber;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public string RegNumber
        {
            get => _regNumber;
            set => _regNumber = value;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegNumber)}: {RegNumber}";
        }

        protected bool Equals(Car other)
        {
            return _regNumber == other._regNumber;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Car) obj);
        }

        public override int GetHashCode()
        {
            return (_regNumber != null ? _regNumber.GetHashCode() : 0);
        }
    }
}
