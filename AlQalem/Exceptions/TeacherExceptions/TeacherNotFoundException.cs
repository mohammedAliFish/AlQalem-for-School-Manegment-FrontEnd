namespace AlQalem.Exceptions.TeacherExceptions
{
    public class TeacherNotFoundException : Exception
    {
        public TeacherNotFoundException(string message= "المعلم غير موجود") : base(message) { }
    }
}
