using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Domain.DomainModels
{
    public class Vektis
    {
        [Key]
        [BindProperty, DataType(DataType.EmailAddress)]
        public int Id { get; set; }
    }
}