namespace AlQalem.Exceptions.UserExceptions
{
    public class UserCreationException : Exception
    {
        public UserCreationException(string message= "حدث خطأ أثناء إنشاء المستخدم") : base(message) { }
    }
}
