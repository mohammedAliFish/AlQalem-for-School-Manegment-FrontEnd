namespace AlQalem.Exceptions.ClassExceptions
{
    public class ClassNotFoundException : Exception
    {
        public ClassNotFoundException(string message= "الصف غير موجود") : base(message)
        {
        }
    }
}
