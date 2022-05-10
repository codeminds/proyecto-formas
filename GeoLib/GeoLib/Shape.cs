namespace GeoLib
{
    public class Shape
    {
        public string Name { get; private set; }

        protected readonly int _quad;

        protected Shape(string name)
        {
            this.Name = name;
            this._quad = 7;
        }

        public virtual float GetArea()
        {
            return 0f;
        }

        public virtual float GetPerimeter()
        {
            return 0f;
        }

        public virtual string Render()
        {
            return "No Render Available";
        }
    }
}
