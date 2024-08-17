
using AlQalem.Exceptions;
using AlQalem.Exceptions.ClassExceptions;
using AlQalem.Exceptions.GradeExceptions;
using AlQalem.Exceptions.SchoolExceptions;
using AlQalem.Exceptions.StudentExceptions;
using AlQalem.Exceptions.SubjectExceptions;
using AlQalem.Exceptions.TeacherExceptions;
using AlQalem.Exceptions.UserExceptions;
using Newtonsoft.Json;

namespace AlQalem.Middlewares
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var statusCode = StatusCodes.Status500InternalServerError;
            var message = "حدث خطأ غير متوقع.";

            switch (exception)
            {
                case CustomException customException:
                    statusCode = StatusCodes.Status400BadRequest;
                    message = customException.Message;
                    break;
                case ClassNotFoundException classNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = classNotFoundException.Message;
                    break;
                case ClassIdMismatchException classIdMismatchException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = classIdMismatchException.Message;
                    break;
                case InvalidClassDataException classNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = classNotFoundException.Message;
                    break;
                case GradeIdMismatchException gradeIdMismatchException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = gradeIdMismatchException.Message;
                    break;
                case GradeNotFoundException gradeNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = gradeNotFoundException.Message;
                    break;
                case InvalidGradeDataException invalidGradeDataException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = invalidGradeDataException.Message;
                    break;
                case InvalidSchoolDataException invalidSchoolDataException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = invalidSchoolDataException.Message;
                    break;
                case LogoUploadException logoUploadException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = logoUploadException.Message;
                    break;
                case SchoolCreationException schoolCreationException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = schoolCreationException.Message;
                    break;
                case SchoolNameAlreadyExistsException schoolNameAlreadyExistsException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = schoolNameAlreadyExistsException.Message;
                    break;
                case SchoolNotFoundException schoolNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = schoolNotFoundException.Message;
                    break;
                case InvalidStudentDataException invalidStudentDataException:
                    statusCode = StatusCodes.Status400BadRequest;
                    message = invalidStudentDataException.Message;
                    break;
                case StudentIdMismatchException studentIdMismatchException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = studentIdMismatchException.Message;
                    break;
                case StudentNotFoundException studentNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = studentNotFoundException.Message;
                    break;
                case SubjectDeletionException subjectDeletionException :
                    statusCode = StatusCodes.Status404NotFound;
                    message = subjectDeletionException.Message;
                    break;
                case SubjectNotFoundException subjectNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = subjectNotFoundException.Message;
                    break;
                case SubjectIdMismatchException subjectIdMismatchException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = subjectIdMismatchException.Message;
                    break;
                case TeacherNotFoundException teacherNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = teacherNotFoundException.Message;
                    break;
                case MismatchedTeacherIdException mismatchedTeacherIdException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = mismatchedTeacherIdException.Message;
                    break;
                case UserIdNotFoundException userIdNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = userIdNotFoundException.Message;
                    break;
                case UserCreationException userCreationException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = userCreationException.Message;
                    break;
                case UserIdMismatchException userIdMismatchException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = userIdMismatchException.Message;
                    break;
                case UserNotFoundException userIdNotFoundException:
                    statusCode = StatusCodes.Status404NotFound;
                    message = userIdNotFoundException.Message;
                    break;
            }


                    context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            var response = new
            {
                StatusCode = statusCode,
                Message = message
            };

            return context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
