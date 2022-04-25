namespace StudentsManager.Classes
{
    public enum ColorType { Primary, Secondary, Success, Error }
    public class ColorCollection
    {
        public static Color Primary = ColorTranslator.FromHtml("#007CF8");
        public static Color LightBlue = ColorTranslator.FromHtml("#00B0FF");
        public static Color Green = ColorTranslator.FromHtml("#00e676");
        public static Color Tomato = ColorTranslator.FromHtml("#F83C5E");
        public static Color Yellow = ColorTranslator.FromHtml("#FFCC00");
        public static Color White = ColorTranslator.FromHtml("#FFFFFF");
        public static Color LightGray = ColorTranslator.FromHtml("#DCE0E4");
        public static Color Gray = ColorTranslator.FromHtml("#3C4044");
        public static Color Black = ColorTranslator.FromHtml("#1E2226");
    }
}
