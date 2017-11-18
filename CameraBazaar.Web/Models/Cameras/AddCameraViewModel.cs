
namespace CameraBazaar.Web.Models.Cameras
{
    using CameraBazaar.Web.Models;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class AddCameraViewModel

    {
        public CameraMakeType Make { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        public decimal Price { get; set; }

        [Range(1, 100)]
        public int Quantity { get; set; }

        [Range(1, 30)]
        [Display(Name = "Min Shutter Speed")]
        public int MinShutterSpeed { get; set; }

        [Range(2000, 8000)]
        [Display(Name = "Max Shutter Speed")]
        public int MaxShutterSpeed { get; set; }

        [Display(Name = "Min ISO")]
        public MinISO MinISO { get; set; }

        [Range(200, 409600)]
        [Display(Name = "Max ISO")]
        public int MaxISO { get; set; }

        [Display(Name = "Frame Full")]
        public bool IsFullFrame { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Video Resolution")]
        public string VideoResolution { get; set; }

        [Display(Name = "Light Metering")]
        public IEnumerable<LightMetering> LightMetering { get; set; }

        [Required]
        [StringLength(6000)]
        public string Description { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 11)]
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
    }
}
