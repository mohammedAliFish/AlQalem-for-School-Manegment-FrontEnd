namespace AlQalem.Exceptions.StudentExceptions
{
    public class StudentNotFoundException : Exception
    {
        public StudentNotFoundException(string message= "الطالب المطلوب غير موجود") : base(message) { }
    }
}
