﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Umbraco.Web.Models.ContentEditing
{
    /// <summary>
    /// A model representing the configuration for a content type defined as a list container
    /// </summary>
    [DataContract(Name = "config", Namespace = "")]
    public class ContentTypeContainerConfiguration
    {
        /// <summary>
        /// The page size for the list
        /// </summary>
        [DataMember(Name = "pageSize")]
        [Required]
        public int PageSize { get; set; }

        /// <summary>
        /// The default order by column for the list
        /// </summary>
        [DataMember(Name = "orderBy")]
        [Required]
        public string OrderBy { get; set; }

        /// <summary>
        /// The default order direction for the list
        /// </summary>
        [DataMember(Name = "orderDirection")]
        [Required]
        public string OrderDirection { get; set; }
    }
}
