﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace vkrS.Models
{
    [DataContract]
    public class TimeSeries
    {
        [Required]
        [DataMember]
        public Guid TimeSeriesId { get; set; }

        [Required]
        [DataMember]
        public bool IsDouble { get; set; }

        [Required]
        [DataMember]
        public string Elements { get; set; }

        [ForeignKey("TimeSeriesId")]
        public virtual List<Result> Results { get; set; }
    }
}