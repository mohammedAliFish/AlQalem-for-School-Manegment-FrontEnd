namespace AlQalem.Exceptions
{
    
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }

    
    public class NotFoundException : CustomException
    {
        public NotFoundException() : base("الطلب غير موجود.") { }
    }

  
    public class ValidationException : CustomException
    {
        public ValidationException() : base("فشل التحقق من صحة البيانات.") { }
    }
}
