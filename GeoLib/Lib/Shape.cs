namespace GeoLib
{
    public class Shape
    {
        public string Name { get; private set; }

        protected Shape(string name) 
        {
            this.Name = name;
        }

        public virtual float GetArea()
        {
            return 0f;
        }

        public virtual float GetPerimeter()
        {
            return 0f;
        }
    }
}
