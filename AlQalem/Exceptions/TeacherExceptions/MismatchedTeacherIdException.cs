namespace AlQalem.Exceptions.TeacherExceptions
{
    public class MismatchedTeacherIdException : Exception
    {
        public MismatchedTeacherIdException(string message= "رقم المعلم غير متطابق") : base(message) { }
    }
}
