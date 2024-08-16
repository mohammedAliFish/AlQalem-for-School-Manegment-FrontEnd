namespace AlQalem.Exceptions.SchoolExceptions
{
    public class SchoolCreationException : Exception
    {
        public SchoolCreationException(string message= "حدث خطأ أثناء إنشاء المدرسة")
            : base(message)
        {
        }
    }
}
