namespace AlQalem.Exceptions.StudentExceptions
{
    public class InvalidStudentDataException : Exception
    {
        public InvalidStudentDataException(string message= "بيانات الطالب غير صالحة") : base(message) { }
    }
}
