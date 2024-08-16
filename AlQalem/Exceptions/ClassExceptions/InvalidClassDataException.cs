namespace AlQalem.Exceptions.ClassExceptions
{
    public class InvalidClassDataException : Exception
    {
        public InvalidClassDataException(string message= "بيانات الصف غير صالحة") : base(message)
        {
        }
    }
}
