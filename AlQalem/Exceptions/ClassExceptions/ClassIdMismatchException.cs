namespace AlQalem.Exceptions.ClassExceptions
{
    public class ClassIdMismatchException : Exception
    {
        public ClassIdMismatchException(string message= "معرف الصف غير متطابق") : base(message)
        {
        }
    }
}
