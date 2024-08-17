namespace AlQalem.Exceptions.UserExceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException(string message = "لم يتم العثور على المستخدم") :base(message) { }

    }
}
