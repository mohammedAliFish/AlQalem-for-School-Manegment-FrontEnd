namespace AlQalem.Exceptions.TeacherExceptions
{
    public class UserIdNotFoundException : Exception
    {
        public UserIdNotFoundException(string message= "رقم المستخدم غير موجود") : base(message) { }
    }
}
