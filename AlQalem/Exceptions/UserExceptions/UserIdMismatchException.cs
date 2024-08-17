namespace AlQalem.Exceptions.UserExceptions
{
    public class UserIdMismatchException : Exception
    {
        public UserIdMismatchException(string message= "مشكله في معرف المستخدم") : base(message) { }
    }
}
