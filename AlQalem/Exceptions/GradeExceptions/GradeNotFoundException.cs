namespace AlQalem.Exceptions.GradeExceptions
{
    public class GradeNotFoundException : Exception
    {
        public GradeNotFoundException(string message= "لم يتم العثور على درجات"):base(message) { }
    }
}
