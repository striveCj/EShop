using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EasyAbp.EShop.Products.Categories.Dtos
{
    public class CreateUpdateCategoryDto
    {
        [DisplayName("CategoryUniqueName")]
        public string UniqueName { get; set; }
        
        [Required]
        [DisplayName("CategoryDisplayName")]
        public string DisplayName { get; set; }

        [DisplayName("CategoryDescription")]
        public string Description { get; set; }

        [DisplayName("CategoryMediaResources")]
        public string MediaResources { get; set; }
    }
}