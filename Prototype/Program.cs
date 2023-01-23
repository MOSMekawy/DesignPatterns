using Prototype.Pattern;

var rect = new Rectangle(10, 10);
var circle = new Circle(20);

var circleClone = (Circle)circle.Clone();

var rectClone = (Rectangle)rect.Clone();