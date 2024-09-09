

using System.ComponentModel.DataAnnotations;

namespace AlQalem.DTOs.Class
{
    public class UpdateClassDTO:CreateClassDTO
    {

        public required Guid ClassId { get; set; }

       
        

    }
}
