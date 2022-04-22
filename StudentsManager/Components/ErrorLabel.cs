using StudentsManager.Classes;

namespace StudentsManager.Components
{
    public class ErrorLabel : Label
    {
        public ErrorLabel()
        {
            this.Font = new Font("Poppins", 9, FontStyle.Bold);
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ForeColor = ColorCollection.Tomato;
        }
    }
}
