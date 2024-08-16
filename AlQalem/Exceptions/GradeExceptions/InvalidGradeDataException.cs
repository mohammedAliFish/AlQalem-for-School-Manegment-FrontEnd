namespace AlQalem.Exceptions.GradeExceptions
{
    public class InvalidGradeDataException : Exception
    {
        public InvalidGradeDataException(string message= "بيانات الدرجة غير صالحة" ) : base(message) { }
    }
}
