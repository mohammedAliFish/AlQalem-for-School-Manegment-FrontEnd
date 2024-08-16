namespace AlQalem.Exceptions.GradeExceptions
{
    public class GradeIdMismatchException : Exception
    {
        public GradeIdMismatchException(string message= "تعارض في معرف الدرجة")
           : base(message)
        {
        }
    }
}
