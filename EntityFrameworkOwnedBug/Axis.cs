using System;

namespace EntityFrameworkOwnedBug
{
    public sealed class Axis
    {
        public Guid Id { get; set; }

        private Vector3 _position = new Vector3();

        public Vector3 Position
        {
            get => _position;
            set => _position = value;
        }

        private Vector3 _range = new Vector3();

        public Vector3 Range
        {
            get => _range;
            set => _range = value;
        }
    }
}
