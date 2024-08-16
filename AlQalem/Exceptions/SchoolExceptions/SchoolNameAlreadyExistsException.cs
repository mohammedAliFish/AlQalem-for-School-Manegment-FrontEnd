namespace AlQalem.Exceptions.SchoolExceptions
{
    public class SchoolNameAlreadyExistsException : Exception
    {
        public SchoolNameAlreadyExistsException(string message = "اسم المدرسة موجود بالفعل") : base(message) { }
    }
}
