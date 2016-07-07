﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool isSubsribedToNewsLetter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
        
        public byte MembershipTypeId { get; set; } //EF will treat as foreign key

        //[Min18YearsIfMember]
        public DateTime? BirthDate { get; set; }
    }
}