namespace StudentsManager.Components.Classes
{
    public enum ColorType { Primary, Secondary, Success, Error }

    public interface ColorTypeSelection
    {
        public ColorType ColorSelected { get; set; }
        public void PaintSelectedColorType();
    }
}
