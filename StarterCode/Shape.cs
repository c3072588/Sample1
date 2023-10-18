/*
 * Do not make any changes to this file for the Worksheet tasks
 * except where the task permits you to.
 */
using System.Drawing;

namespace StarterCode.Shapes
{
    /// <summary>
    /// This base class represents a generic shape, 
    /// to represent a shape in a "graphics system".
    /// It has a height and width, and colour but 
    /// can also be positioned at a point specified by X and Y.
    /// </summary>
    internal class Shape
    {
        internal Color ShapeColor { get; set; } = Color.White;
        internal int CenterX { get; set; }
        internal int CenterY { get; set; }
        protected float _height;
        internal float Height {
            get { 
                return _height; 
            }
            set { 
                _height = ClampToMinimum(value);
            } 
        }
        protected float _width;
        internal float Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = ClampToMinimum(value);
            }
        }

        /// <summary>
        /// Note the use of default values in this constructor.
        /// This applies to all functions and methods.
        /// Parameters with default values must appear as the right most parameters
        /// in the parameter list and where default values are specified, the 
        /// parameter is concidered optional. This means you can use this constructor
        /// without specifying any parameter at all.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="heigt"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Shape(float width = 0, float heigt = 0)
        {
            Width = width;
            Height = heigt;
        }

        protected internal float ClampToMinimum(float value)
        {
            // "return value < 0 ? 0 : value" is a shortcut for
            //if (value < 0) return 0;
            //else return value;
            // It uses the ternary conditional operator ?
            // which you can learn about here:
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            return value < 0 ? 0 : value;
        }

        virtual protected internal float ComputeArea()
        {
            return Height * Width;
        }

        virtual protected internal float ComputeCircumference() {
            return (2 * Height) + (2 * Width);
        }

        /// <summary>
        /// This virtual method prints out a message to the console to 
        /// simulate the shape being drawn. Since it is a virtual method, 
        /// a subclass of Shape can override this method so that it 
        /// "draws" that specific shape, and not a generic Shape.
        /// </summary>
        virtual protected internal void Draw()
        {
            Console.WriteLine($"Shape class drawing {this}.");
        }
        

        /// <summary>
        /// Overides the ToString() method that all classes inherit 
        /// from the Object. Object is the base class of all C# classes
        /// </summary>
        /// <returns>A string that represents a Shape object</returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
