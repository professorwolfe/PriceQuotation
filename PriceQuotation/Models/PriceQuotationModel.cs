using System.ComponentModel.DataAnnotations;

namespace PriceQuotation.Models
{
    public class PriceQuotationModel
    {
        [Required(ErrorMessage = "Please enter a number greater than 0.")]
        [Range(1, 100000, ErrorMessage =
               "Total price must be between 1 and 100000.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage = "Please enter a number under a 100 ")]
        [Range(0.1, 100, ErrorMessage =
               "Discount must be between 0.1 and 100.")]
        public decimal? DiscountPercent { get; set; }


        public int? DiscountAmount { get; set; }

        public decimal? CalculateDiscountAmount()
        {
            decimal? discount = Subtotal * (DiscountPercent / 100);

            return discount;
        }

        public decimal? CalculateTotal()
        {
            decimal? discount = Subtotal * (DiscountPercent / 100);
            decimal? total = Subtotal - discount;

            return total;
        }
    }
}